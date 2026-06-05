using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventAttendace.UserControls
{
    public partial class UC_Report : UserControl
    {
        private string connectionString =
           @"Data Source=DREWWW\SQLEXPRESS;Initial Catalog=EventAttendancerecord;Integrated Security=True;TrustServerCertificate=True";
        public UC_Report()
        {
            InitializeComponent();
            LoadEvents();
            LoadReports();
        }
        private void LoadEvents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT EventID, EventName FROM Event", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbEvent.DataSource = dt;
                cbEvent.DisplayMember = "EventName";
                cbEvent.ValueMember = "EventID";
            }
        }
        private void LoadReports()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT R.ReportID, E.EventName, U.UserName AS GeneratedBy,
                           R.GeneratedDate, R.FilePath
                    FROM Report R
                    INNER JOIN Event E ON R.EventID = E.EventID
                    LEFT JOIN Users U ON R.GeneratedBy = U.UserID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReport.DataSource = dt;
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(cbEvent.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Report (EventID, GeneratedDate, FilePath, GeneratedBy)
                    VALUES (@eventId, GETDATE(), NULL, NULL)", conn);
                cmd.Parameters.AddWithValue("@eventId", eventId);
                cmd.Parameters.AddWithValue("@userId", CurrentUser.UserID);
                cmd.ExecuteNonQuery();
            }

            LoadReports();
        }
        private void GenerateReportPdf(int eventId, string filePath)
        {
            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        var titleFont = iTextSharp.text.FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);
                        var title = new iTextSharp.text.Paragraph("Event Report", titleFont);
                        title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        title.SpacingAfter = 10f;
                        doc.Add(title);

                        SqlCommand cmdEvent = new SqlCommand("SELECT EventName FROM Event WHERE EventID = @eventId", conn);
                        cmdEvent.Parameters.AddWithValue("@eventId", eventId);
                        string eventName = cmdEvent.ExecuteScalar()?.ToString() ?? "Unknown Event";

                        var eventFont = iTextSharp.text.FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.NORMAL);
                        var eventParagraph = new iTextSharp.text.Paragraph(eventName, eventFont);
                        eventParagraph.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        eventParagraph.SpacingAfter = 15f;
                        doc.Add(eventParagraph);

                        var sectionFont = iTextSharp.text.FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);

                        var attendanceTitle = new iTextSharp.text.Paragraph("Attendance Summary", sectionFont);
                        attendanceTitle.SpacingAfter = 5f;
                        doc.Add(attendanceTitle);

                        SqlCommand cmdSummary = new SqlCommand(@"
                            SELECT COUNT(*) AS TotalAttendees
                            FROM AttendanceRecord
                            WHERE EventID = @eventId", conn);
                        cmdSummary.Parameters.AddWithValue("@eventId", eventId);
                        int totalAttendees = (int)cmdSummary.ExecuteScalar();

                        PdfPTable summaryTable = new PdfPTable(2);
                        summaryTable.WidthPercentage = 100;
                        summaryTable.SpacingBefore = 5f;
                        summaryTable.SpacingAfter = 15f;
                        summaryTable.AddCell("Detail");
                        summaryTable.AddCell("Count");
                        summaryTable.AddCell("Total Attendees");
                        summaryTable.AddCell(totalAttendees.ToString());
                        doc.Add(summaryTable);

                        var rateTitle = new iTextSharp.text.Paragraph("Participation Rate", sectionFont);
                        rateTitle.SpacingAfter = 5f;
                        doc.Add(rateTitle);

                        SqlCommand cmdRate = new SqlCommand(@"
                            SELECT COUNT(*) AS Registered,
                            SUM(CASE WHEN Status = 'Present' THEN 1 ELSE 0 END) AS Attended
                            FROM AttendanceRecord
                            WHERE EventID = @eventId", conn);
                        cmdRate.Parameters.AddWithValue("@eventId", eventId);
                        SqlDataReader readerRate = cmdRate.ExecuteReader();
                        if (readerRate.Read())
                        {
                            int registered = Convert.ToInt32(readerRate["Registered"]);
                            int attended = Convert.ToInt32(readerRate["Attended"]);
                            double rate = registered > 0 ? (attended * 100.0 / registered) : 0;

                            PdfPTable rateTable = new PdfPTable(3);
                            rateTable.WidthPercentage = 100;
                            rateTable.SpacingBefore = 5f;
                            rateTable.SpacingAfter = 15f;
                            rateTable.AddCell("Registered");
                            rateTable.AddCell("Attended");
                            rateTable.AddCell("Rate");
                            rateTable.AddCell(registered.ToString());
                            rateTable.AddCell(attended.ToString());
                            rateTable.AddCell($"{rate:F2}%");
                            doc.Add(rateTable);
                        }
                        readerRate.Close();

                        var listTitle = new iTextSharp.text.Paragraph("Student Attendance List", sectionFont);
                        listTitle.SpacingAfter = 5f;
                        doc.Add(listTitle);

                        SqlCommand cmdList = new SqlCommand(@"
                            SELECT A.FirstName, A.LastName, AR.Status
                            FROM AttendanceRecord AR
                            INNER JOIN Attendee A ON AR.AttendeeID = A.AttendeeID
                            WHERE AR.EventID = @eventId", conn);
                        cmdList.Parameters.AddWithValue("@eventId", eventId);
                        SqlDataReader readerList = cmdList.ExecuteReader();

                        PdfPTable listTable = new PdfPTable(2);
                        listTable.WidthPercentage = 100;
                        listTable.SpacingBefore = 5f;
                        listTable.SpacingAfter = 15f;
                        listTable.AddCell("Name");
                        listTable.AddCell("Status");
                        while (readerList.Read())
                        {
                            string firstName = readerList["FirstName"].ToString();
                            string lastName = readerList["LastName"].ToString();
                            string status = readerList["Status"].ToString();
                            listTable.AddCell($"{firstName} {lastName}");
                            listTable.AddCell(status);
                        }
                        readerList.Close();
                        doc.Add(listTable);
                    }

                    doc.Close();
                }
            }
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.SelectedRows.Count > 0)
            {
                int reportId = Convert.ToInt32(dataGridViewReport.SelectedRows[0].Cells["ReportID"].Value);
                int eventId = Convert.ToInt32(cbEvent.SelectedValue);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    GenerateReportPdf(eventId, filePath);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(@"
                    UPDATE Report SET FilePath = @filePath WHERE ReportID = @reportId", conn);
                        cmd.Parameters.AddWithValue("@filePath", filePath);
                        cmd.Parameters.AddWithValue("@reportId", reportId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadReports();
                    MessageBox.Show("Report saved and PDF generated at: " + filePath);
                }
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(cbEvent.SelectedValue);
                string filePath = dataGridViewReport.SelectedRows[0].Cells["FilePath"].Value?.ToString();

                if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    string tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "PreviewReport.pdf");
                    GenerateReportPdf(eventId, tempPath);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = tempPath,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.SelectedRows.Count > 0)
            {
                int reportId = Convert.ToInt32(dataGridViewReport.SelectedRows[0].Cells["ReportID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this report?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Report WHERE ReportID = @reportId", conn);
                        cmd.Parameters.AddWithValue("@reportId", reportId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadReports();
                    MessageBox.Show("Report deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a report to delete.");
            }
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (CurrentUser.Role == "Member")
            {
                btnDelete.Enabled = false;
                btnGenerate.Enabled = false;
                btnSaveReport.Enabled = true;
                btnShowReport.Enabled = true;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewReport.DataSource is DataTable dt)
            {
                string filterText = txtFilter.Text.Replace("'", "''");
                dt.DefaultView.RowFilter = string.Format(
                    "EventName LIKE '%{0}%' OR GeneratedBy LIKE '%{0}%' OR FilePath LIKE '%{0}%' OR CONVERT(GeneratedDate, 'System.String') LIKE '%{0}%'",
                    filterText);
            }
        }

        private void UC_Report_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(90, 0, 150),
                Color.FromArgb(180, 120, 255),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}


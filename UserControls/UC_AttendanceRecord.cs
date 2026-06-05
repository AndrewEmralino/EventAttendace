using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace EventAttendace.UserControls
{
    public partial class UC_AttendanceRecord : UserControl
    {
        private string connectionString =
           @"Data Source=DREWWW\SQLEXPRESS;Initial Catalog=EventAttendancerecord;Integrated Security=True;TrustServerCertificate=True";
        public UC_AttendanceRecord()
        {
            InitializeComponent();
        }
        private void LoadYearLevels()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT YearID, YearName FROM YearLevel", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbYearLvl.DataSource = dt;
                cbYearLvl.DisplayMember = "YearName";
                cbYearLvl.ValueMember = "YearID";
                cbYearLvl.SelectedIndex = -1;
            }
        }
        private void LoadEvents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT EventID, EventName FROM Event", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbEvent.DataSource = dt;
                cbEvent.DisplayMember = "EventName";
                cbEvent.ValueMember = "EventID";
                cbEvent.SelectedIndex = -1;
            }
        }
        private void LoadAttendanceByEvent()
        {
            if (cbEvent.SelectedValue == null) return;

            int eventId;
            if (!int.TryParse(cbEvent.SelectedValue.ToString(), out eventId)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT AR.AttendanceID,
                           E.EventName,
                           (A.FirstName + ' ' + A.LastName) AS FullName,
                           Y.YearName,
                           AR.Status,
                           AR.TimeStamp
                    FROM AttendanceRecord AR
                    INNER JOIN Event E ON AR.EventID = E.EventID
                    INNER JOIN Attendee A ON AR.AttendeeID = A.AttendeeID
                    INNER JOIN YearLevel Y ON A.YearID = Y.YearID
                    WHERE AR.EventID = @eventId";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@eventId", Convert.ToInt32(cbEvent.SelectedValue));

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAttendance.DataSource = dt;

                dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                if (dataGridViewAttendance.Columns["AttendanceID"] != null)
                    dataGridViewAttendance.Columns["AttendanceID"].Visible = false;
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (cbEvent.SelectedValue == null || cbStudentList.SelectedValue == null)
            {
                MessageBox.Show("Please select Event and Attendee.");
                return;
            }

            int eventId, attendeeId;
            if (!int.TryParse(cbEvent.SelectedValue.ToString(), out eventId)) return;
            if (!int.TryParse(cbStudentList.SelectedValue.ToString(), out attendeeId)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AttendanceRecord (EventID, AttendeeID, Status, TimeStamp) VALUES (@eventId, @attendeeId, @status, @timeStamp)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@eventId", eventId);
                cmd.Parameters.AddWithValue("@attendeeId", attendeeId);

                // ✅ If no status selected, insert NULL
                if (cbStatus.SelectedItem == null)
                    cmd.Parameters.AddWithValue("@status", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString());

                cmd.Parameters.AddWithValue("@timeStamp", dtpAttendanceTime.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadAttendanceByEvent();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            cbYearLvl.SelectedIndex = -1;
            cbEvent.SelectedIndex = -1;
            cbStudentList.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttendance.CurrentRow == null) return;

            int attendanceId = Convert.ToInt32(dataGridViewAttendance.CurrentRow.Cells["AttendanceID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE AttendanceRecord SET Status = @status WHERE AttendanceID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id", attendanceId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadAttendanceByEvent();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttendance.CurrentRow == null) return;

            int attendanceId = Convert.ToInt32(dataGridViewAttendance.CurrentRow.Cells["AttendanceID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM AttendanceRecord WHERE AttendanceID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", attendanceId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadAttendanceByEvent();
        }

        private void dataGridViewAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbEvent.Text = dataGridViewAttendance.Rows[e.RowIndex].Cells["EventName"].Value.ToString();
                cbStudentList.Text = dataGridViewAttendance.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                cbStatus.Text = dataGridViewAttendance.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                cbYearLvl.Text = dataGridViewAttendance.Rows[e.RowIndex].Cells["YearName"].Value.ToString();
            }
        }

        private void UC_AttendanceRecord_Load(object sender, EventArgs e)
        {
            LoadYearLevels();
            LoadEvents();
            LoadAttendanceByEvent();
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Present");
            cbStatus.Items.Add("Absent");
            cbStatus.Items.Add("Late");

            if (CurrentUser.Role == "Member")
            {
                butAdd.Enabled = false;
                butUpdate.Enabled = false;
                butDelete.Enabled = false;
                butClear.Enabled = false;
            }

        }

        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceByEvent();

        }

        private void cbYearLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYearLvl.SelectedValue == null) return;

            int yearId;
            if (!int.TryParse(cbYearLvl.SelectedValue.ToString(), out yearId)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AttendeeID, (FirstName + ' ' + LastName) AS FullName FROM Attendee WHERE YearID = @yearId";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@yearId", Convert.ToInt32(cbYearLvl.SelectedValue));

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbStudentList.DataSource = dt;
                cbStudentList.DisplayMember = "FullName";
                cbStudentList.ValueMember = "AttendeeID";
                cbStudentList.SelectedIndex = -1;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewAttendance.DataSource is DataTable dt)
            {
                string filterText = txtFilter.Text.Replace("'", "''"); // escape quotes
                dt.DefaultView.RowFilter = string.Format(
                    "EventName LIKE '%{0}%' OR FullName LIKE '%{0}%' OR YearName LIKE '%{0}%' OR Status LIKE '%{0}%' OR CONVERT(TimeStamp, 'System.String') LIKE '%{0}%'",
                    filterText);
            }
        }

        private void UC_AttendanceRecord_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
            this.ClientRectangle,
            Color.FromArgb(90, 0, 150),   // Deep violet
            Color.FromArgb(180, 120, 255), // Soft lavender
            LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}

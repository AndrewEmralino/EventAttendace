using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventAttendace.UserControls
{
    public partial class UC_Attendee : UserControl
    {
        private string connectionString =
            @"Data Source=DREWWW\SQLEXPRESS;Initial Catalog=EventAttendancerecord;Integrated Security=True;TrustServerCertificate=True";
        public UC_Attendee()
        {
            InitializeComponent();
        }
        private void LoadDepartments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DeptID, DeptName FROM Department", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbDept.DataSource = dt;
                cbDept.DisplayMember = "DeptName";
                cbDept.ValueMember = "DeptID";
                cbDept.SelectedIndex = -1;
            }
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
        private void LoadAttendees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT A.AttendeeID, A.FirstName, A.LastName, A.ContactInformation, D.DeptName, y.YearName " +
                    "FROM Attendee A " +
                    "INNER JOIN Department D ON A.DeptID = D.DeptID " +
                    "INNER JOIN YearLevel Y ON A.YearID = Y.YearID", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStudent.DataSource = dt;

                if (dataGridViewStudent.Columns["AttendeeID"] != null)
                    dataGridViewStudent.Columns["AttendeeID"].Visible = false;

                dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn col in dataGridViewStudent.Columns)
                {
                    col.FillWeight = 1;
                }
            }
        }
        private void ClearFields()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtCNumber.Clear();
            cbDept.SelectedIndex = -1;
            cbYearLvl.SelectedIndex = -1;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Attendee (FirstName, LastName, ContactInformation, DeptID, YearID) " +
                        "VALUES (@fname, @lname, @contact, @dept, @year)", conn);
                    cmd.Parameters.AddWithValue("@fname", txtFName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtCNumber.Text);
                    cmd.Parameters.AddWithValue("@dept", cbDept.SelectedValue);
                    cmd.Parameters.AddWithValue("@year", cbYearLvl.SelectedValue);
                    cmd.ExecuteNonQuery();
                }
                LoadAttendees();
                ClearFields();
            }

        private void butClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void UC_Attendee_Load(object sender, EventArgs e)
        {
            LoadYearLevels();
            LoadDepartments();
            LoadAttendees();
            if (CurrentUser.Role == "Member")
            {
                butAdd.Enabled = false;
                butUpdate.Enabled = false;
                butDelete.Enabled = false;
                butClear.Enabled = false;
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.CurrentRow != null)
            {
                int attendeeId = Convert.ToInt32(dataGridViewStudent.CurrentRow.Cells["AttendeeID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Attendee SET FirstName=@fname, LastName=@lname, ContactInformation=@contact, DeptID=@dept, YearID=@year " +
                        "WHERE AttendeeID=@id", conn);
                    cmd.Parameters.AddWithValue("@fname", txtFName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtCNumber.Text);
                    cmd.Parameters.AddWithValue("@dept", cbDept.SelectedValue);
                    cmd.Parameters.AddWithValue("@year", cbYearLvl.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", attendeeId);
                    cmd.ExecuteNonQuery();
                }
                LoadAttendees();
                ClearFields();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.CurrentRow != null)
            {
                int attendeeId = Convert.ToInt32(dataGridViewStudent.CurrentRow.Cells["AttendeeID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Attendee WHERE AttendeeID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", attendeeId);
                    cmd.ExecuteNonQuery();
                }
                LoadAttendees();
                ClearFields();
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewStudent.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewStudent.CurrentRow;

                txtFName.Text = row.Cells["FirstName"].Value?.ToString();
                txtLName.Text = row.Cells["LastName"].Value?.ToString();
                txtCNumber.Text = row.Cells["ContactInformation"].Value?.ToString();
                cbDept.Text = row.Cells["DeptName"].Value?.ToString();
                cbYearLvl.Text = row.Cells["YearName"].Value?.ToString();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudent.DataSource is DataTable dt)
            {
                string filterText = txtFilter.Text.Replace("'", "''"); // escape quotes
                dt.DefaultView.RowFilter = string.Format(
                    "FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%' OR ContactInformation LIKE '%{0}%' OR DeptName LIKE '%{0}%' OR YearName LIKE '%{0}%'",
                    filterText);
            }
        }

        private void UC_Attendee_Paint(object sender, PaintEventArgs e)
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

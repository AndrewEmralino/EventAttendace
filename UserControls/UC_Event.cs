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

namespace EventAttendace.UserControls
{
    public partial class UC_Event : UserControl
    {
        private string connectionString =
            @"Data Source=DREWWW\SQLEXPRESS;Initial Catalog=EventAttendancerecord;Integrated Security=True;TrustServerCertificate=True";
        public UC_Event()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM EventCategory", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCategory.DataSource = dt;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
                cbCategory.SelectedIndex = -1;
            }
        }

        private void LoadEvents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT E.EventID, E.EventName, E.EventDate, E.Location, E.CategoryID, C.CategoryName, U.Username " +
                    "FROM Event E " +
                    "INNER JOIN EventCategory C ON E.CategoryID = C.CategoryID " +
                    "INNER JOIN Users U ON E.UserID = U.UserID", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEvents.DataSource = dt;

                // Hide ID columns
                if (dataGridViewEvents.Columns["EventID"] != null)
                    dataGridViewEvents.Columns["EventID"].Visible = false;
                if (dataGridViewEvents.Columns["CategoryID"] != null)
                    dataGridViewEvents.Columns["CategoryID"].Visible = false;
                if (dataGridViewEvents.Columns["EventDate"] != null)
                {
                    dataGridViewEvents.Columns["EventDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                }
                // Auto-size columns
                dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn col in dataGridViewEvents.Columns)
                {
                    col.FillWeight = 1; // equal distribution
                }
            }
        }
        private void ClearFields()
        {
            txtEventName.Clear();
            txtLocation.Clear();
            dtpDate.Value = DateTime.Now;
            cbCategory.SelectedIndex = -1;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                errorProvider1.SetError(txtEventName, "Event Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEventName, "");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Event (EventName, EventDate, Location, CategoryID, UserID) " +
                    "VALUES (@name, @date, @loc, @cat, @userId)", conn);

                cmd.Parameters.AddWithValue("@name", txtEventName.Text);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@loc", txtLocation.Text);
                cmd.Parameters.AddWithValue("@cat", cbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@userId", CurrentUser.UserID); // ✅ include UserID

                cmd.ExecuteNonQuery();
            }
            LoadEvents();
            ClearFields();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.CurrentRow != null)
            {
                int eventId = Convert.ToInt32(dataGridViewEvents.CurrentRow.Cells["EventID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Event SET EventName=@name, EventDate=@date, Location=@loc, CategoryID=@cat WHERE EventID=@id", conn);
                    cmd.Parameters.AddWithValue("@name", txtEventName.Text);
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@loc", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@cat", cbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", eventId);
                    cmd.ExecuteNonQuery();
                }
                LoadEvents();
                ClearFields();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.CurrentRow != null)
            {
                int eventId = Convert.ToInt32(dataGridViewEvents.CurrentRow.Cells["EventID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Event WHERE EventID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", eventId);
                    cmd.ExecuteNonQuery();
                }
                LoadEvents();
                ClearFields();
            }

        }

        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewEvents.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewEvents.CurrentRow;

                txtEventName.Text = row.Cells["EventName"].Value?.ToString();
                txtLocation.Text = row.Cells["Location"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["EventDate"].Value?.ToString(), out DateTime eventDate))
                {
                    dtpDate.Value = eventDate;
                }

                if (row.Cells["CategoryID"].Value != null)
                {
                    cbCategory.SelectedValue = row.Cells["CategoryID"].Value;
                }
            }
        }

        private void UC_Event_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadEvents();
            if (CurrentUser.Role == "Member")
            {
                butAdd.Enabled = false;
                butUpdate.Enabled = false;
                butDelete.Enabled = false;
                butClear.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewEvents.DataSource is DataTable dt)
            {
                string filterText = txtFilter.Text.Replace("'", "''"); 
                dt.DefaultView.RowFilter = string.Format(
                    "EventName LIKE '%{0}%' OR Location LIKE '%{0}%' OR CategoryName LIKE '%{0}%' OR Username LIKE '%{0}%' OR CONVERT(EventDate, 'System.String') LIKE '%{0}%'",
                    filterText);
            }
        }

        private void UC_Event_Paint(object sender, PaintEventArgs e)
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


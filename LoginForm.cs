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

namespace EventAttendace
{
    public partial class frmLogin : Form
    {
        private string connectionString =
           @"Data Source=DREWWW\SQLEXPRESS;Initial Catalog=EventAttendancerecord;Integrated Security=True;TrustServerCertificate=True";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pBoxMin.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxMax.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBoxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = txtRole.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT UserID, Role FROM Users WHERE Username=@username AND PasswordHash=@password AND Role=@role", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    CurrentUser.UserID = Convert.ToInt32(reader["UserID"]);
                    CurrentUser.Username = username;
                    CurrentUser.Role = reader["Role"].ToString();

                    MessageBox.Show($"Account successfully login! Role: {CurrentUser.Role}");

                    frmMMenu mainMenu = new frmMMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.");
                }
            }

        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
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

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                btnLogin.ClientRectangle,
                Color.FromArgb(120, 0, 200),   // Deep purple
                Color.FromArgb(180, 120, 255), // Light lavender
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, btnLogin.ClientRectangle);
            }
            using (SolidBrush overlay = new SolidBrush(Color.FromArgb(40, 0, 180, 170)))
            {
                e.Graphics.FillRectangle(overlay, btnLogin.ClientRectangle);
            }
            TextRenderer.DrawText(
            e.Graphics,
            btnLogin.Text,
            btnLogin.Font,
            btnLogin.ClientRectangle,
            Color.White,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}

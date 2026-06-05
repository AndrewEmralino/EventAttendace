using EventAttendace.UserControls;
using EventAttendace.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventAttendace
{
    public partial class frmMMenu : Form
    {
        public frmMMenu()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        bool menuExpand = false;
        private void frmMMenu_Load(object sender, EventArgs e)
        {
            pBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxMin.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxMax.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
        }

        bool sideBarExpand = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if(sideBar.Width <= 60)
                {
                    sideBarExpand = false;
                    sideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if(sideBar.Width >= 160)
                {
                    sideBarExpand = true;
                    sideBarTransition.Stop();
                }
            }
        }

        private void pBoxMenu_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            UC_Event uc = new UC_Event();
            addUserControl(uc);
            uc.Dock = DockStyle.Fill;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(uc);
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

        private void btnStudent_Click(object sender, EventArgs e)
        {
            UC_Attendee uc = new UC_Attendee();
            addUserControl(uc);
            uc.Dock = DockStyle.Fill;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(uc);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            UC_AttendanceRecord uc = new UC_AttendanceRecord();
            addUserControl(uc);
            uc.Dock = DockStyle.Fill;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(uc);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            UC_Report uc = new UC_Report();
            addUserControl(uc);
            uc.Dock = DockStyle.Fill;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin wf = new frmLogin();
            wf.Show();

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                pContainer.ClientRectangle,
                Color.FromArgb(90, 0, 150),   
                Color.FromArgb(180, 120, 255), 
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, pContainer.ClientRectangle);
            }
        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {
        }
    }
    }


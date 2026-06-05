namespace EventAttendace
{
    partial class frmMMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxMin = new System.Windows.Forms.PictureBox();
            this.pBoxMax = new System.Windows.Forms.PictureBox();
            this.pBoxExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxMenu = new System.Windows.Forms.PictureBox();
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMenu)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pBoxMin);
            this.panel1.Controls.Add(this.pBoxMax);
            this.panel1.Controls.Add(this.pBoxExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBoxMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 60);
            this.panel1.TabIndex = 0;
            // 
            // pBoxMin
            // 
            this.pBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxMin.Image = global::EventAttendace.Properties.Resources.icons8_minimize_50;
            this.pBoxMin.Location = new System.Drawing.Point(1185, 0);
            this.pBoxMin.Name = "pBoxMin";
            this.pBoxMin.Size = new System.Drawing.Size(48, 60);
            this.pBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxMin.TabIndex = 4;
            this.pBoxMin.TabStop = false;
            this.pBoxMin.Click += new System.EventHandler(this.pBoxMin_Click);
            // 
            // pBoxMax
            // 
            this.pBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxMax.Image = global::EventAttendace.Properties.Resources.icons8_maximize_window_48;
            this.pBoxMax.Location = new System.Drawing.Point(1233, 0);
            this.pBoxMax.Name = "pBoxMax";
            this.pBoxMax.Size = new System.Drawing.Size(48, 60);
            this.pBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxMax.TabIndex = 3;
            this.pBoxMax.TabStop = false;
            this.pBoxMax.Click += new System.EventHandler(this.pBoxMax_Click);
            // 
            // pBoxExit
            // 
            this.pBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxExit.Image = global::EventAttendace.Properties.Resources.icons8_close_50;
            this.pBoxExit.Location = new System.Drawing.Point(1281, 0);
            this.pBoxExit.Name = "pBoxExit";
            this.pBoxExit.Size = new System.Drawing.Size(48, 60);
            this.pBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxExit.TabIndex = 2;
            this.pBoxExit.TabStop = false;
            this.pBoxExit.Click += new System.EventHandler(this.pBoxExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEXI Event Attendance Recorder";
            // 
            // pBoxMenu
            // 
            this.pBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMenu.Image = global::EventAttendace.Properties.Resources.icons8_menu_button_48;
            this.pBoxMenu.Location = new System.Drawing.Point(15, 3);
            this.pBoxMenu.Name = "pBoxMenu";
            this.pBoxMenu.Size = new System.Drawing.Size(47, 50);
            this.pBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxMenu.TabIndex = 1;
            this.pBoxMenu.TabStop = false;
            this.pBoxMenu.Click += new System.EventHandler(this.pBoxMenu_Click);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 50;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // sideBar
            // 
            this.sideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel6);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 60);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(214, 654);
            this.sideBar.TabIndex = 3;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEvents);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 58);
            this.panel3.TabIndex = 5;
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Image = global::EventAttendace.Properties.Resources.errm__1___1_;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(-5, -12);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEvents.Size = new System.Drawing.Size(298, 83);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "         Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnStudent);
            this.panel4.Location = new System.Drawing.Point(3, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 58);
            this.panel4.TabIndex = 5;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::EventAttendace.Properties.Resources.icons8_person_30__1_;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(-5, -11);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(318, 83);
            this.btnStudent.TabIndex = 7;
            this.btnStudent.Text = "         Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAttendance);
            this.panel6.Location = new System.Drawing.Point(3, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 58);
            this.panel6.TabIndex = 5;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = global::EventAttendace.Properties.Resources.icons8_attendance_40__1_;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(-6, -16);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(298, 83);
            this.btnAttendance.TabIndex = 8;
            this.btnAttendance.Text = "         Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnReport);
            this.panel5.Location = new System.Drawing.Point(3, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 58);
            this.panel5.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::EventAttendace.Properties.Resources.icons8_report_48__1_;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-7, -20);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(298, 83);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "         Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(3, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 58);
            this.panel2.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::EventAttendace.Properties.Resources.icons8_log_out_48__1_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-7, -20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(298, 83);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "         Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.Purple;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(214, 60);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1115, 654);
            this.pContainer.TabIndex = 4;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // frmMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 714);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MMenu";
            this.Load += new System.EventHandler(this.frmMMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMenu)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBoxMin;
        private System.Windows.Forms.PictureBox pBoxMax;
        private System.Windows.Forms.PictureBox pBoxExit;
        private System.Windows.Forms.Timer sideBarTransition;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pContainer;
    }
}
namespace EventAttendace
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxMin = new System.Windows.Forms.PictureBox();
            this.pBoxMax = new System.Windows.Forms.PictureBox();
            this.pBoxExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pBoxMin);
            this.panel1.Controls.Add(this.pBoxMax);
            this.panel1.Controls.Add(this.pBoxExit);
            this.panel1.Controls.Add(this.label1);
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
            this.pBoxMin.Location = new System.Drawing.Point(1181, 0);
            this.pBoxMin.Name = "pBoxMin";
            this.pBoxMin.Size = new System.Drawing.Size(50, 60);
            this.pBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxMin.TabIndex = 8;
            this.pBoxMin.TabStop = false;
            this.pBoxMin.Click += new System.EventHandler(this.pBoxMin_Click);
            // 
            // pBoxMax
            // 
            this.pBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxMax.Image = global::EventAttendace.Properties.Resources.icons8_maximize_window_48;
            this.pBoxMax.Location = new System.Drawing.Point(1231, 0);
            this.pBoxMax.Name = "pBoxMax";
            this.pBoxMax.Size = new System.Drawing.Size(48, 60);
            this.pBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxMax.TabIndex = 7;
            this.pBoxMax.TabStop = false;
            this.pBoxMax.Click += new System.EventHandler(this.pBoxMax_Click);
            // 
            // pBoxExit
            // 
            this.pBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxExit.Image = global::EventAttendace.Properties.Resources.icons8_close_50;
            this.pBoxExit.Location = new System.Drawing.Point(1279, 0);
            this.pBoxExit.Name = "pBoxExit";
            this.pBoxExit.Size = new System.Drawing.Size(50, 60);
            this.pBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxExit.TabIndex = 6;
            this.pBoxExit.TabStop = false;
            this.pBoxExit.Click += new System.EventHandler(this.pBoxExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "NEXI Event Attendance Recorder";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(432, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Login:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(506, 217);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 32);
            this.txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(506, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(320, 32);
            this.txtPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(394, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(506, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 37);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLogin_Paint);
            // 
            // txtRole
            // 
            this.txtRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(506, 304);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(320, 32);
            this.txtRole.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(441, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Role:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1329, 714);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLogin_Paint);
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxMin;
        private System.Windows.Forms.PictureBox pBoxMax;
        private System.Windows.Forms.PictureBox pBoxExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label5;
    }
}
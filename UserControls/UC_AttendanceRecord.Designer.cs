namespace EventAttendace.UserControls
{
    partial class UC_AttendanceRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudentList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.butClear = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYearLvl = new System.Windows.Forms.ComboBox();
            this.dtpAttendanceTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Event";
            // 
            // cbEvent
            // 
            this.cbEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvent.Location = new System.Drawing.Point(7, 53);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(236, 31);
            this.cbEvent.TabIndex = 31;
            this.cbEvent.SelectedIndexChanged += new System.EventHandler(this.cbEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Student List";
            // 
            // cbStudentList
            // 
            this.cbStudentList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentList.Location = new System.Drawing.Point(253, 53);
            this.cbStudentList.Name = "cbStudentList";
            this.cbStudentList.Size = new System.Drawing.Size(236, 31);
            this.cbStudentList.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Student Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.Location = new System.Drawing.Point(253, 117);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(236, 31);
            this.cbStatus.TabIndex = 35;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttendance.ColumnHeadersHeight = 29;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(5, 241);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.RowHeadersWidth = 51;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(1099, 383);
            this.dataGridViewAttendance.TabIndex = 44;
            this.dataGridViewAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAttendance_CellClick);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.White;
            this.butClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(637, 113);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(124, 34);
            this.butClear.TabIndex = 39;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.White;
            this.butAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(507, 113);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(124, 34);
            this.butAdd.TabIndex = 38;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(850, 203);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(124, 34);
            this.butUpdate.TabIndex = 41;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(980, 203);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(124, 34);
            this.butDelete.TabIndex = 40;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Year Level";
            // 
            // cbYearLvl
            // 
            this.cbYearLvl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearLvl.Location = new System.Drawing.Point(7, 117);
            this.cbYearLvl.Name = "cbYearLvl";
            this.cbYearLvl.Size = new System.Drawing.Size(236, 31);
            this.cbYearLvl.TabIndex = 42;
            this.cbYearLvl.SelectedIndexChanged += new System.EventHandler(this.cbYearLvl_SelectedIndexChanged);
            // 
            // dtpAttendanceTime
            // 
            this.dtpAttendanceTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpAttendanceTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttendanceTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAttendanceTime.Location = new System.Drawing.Point(507, 53);
            this.dtpAttendanceTime.Name = "dtpAttendanceTime";
            this.dtpAttendanceTime.ShowUpDown = true;
            this.dtpAttendanceTime.Size = new System.Drawing.Size(254, 32);
            this.dtpAttendanceTime.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 28);
            this.label6.TabIndex = 48;
            this.label6.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(7, 206);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(333, 30);
            this.txtFilter.TabIndex = 47;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // UC_AttendanceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpAttendanceTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYearLvl);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStudentList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEvent);
            this.Name = "UC_AttendanceRecord";
            this.Size = new System.Drawing.Size(1109, 654);
            this.Load += new System.EventHandler(this.UC_AttendanceRecord_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UC_AttendanceRecord_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYearLvl;
        private System.Windows.Forms.DateTimePicker dtpAttendanceTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilter;
    }
}

namespace EventAttendace.UserControls
{
    partial class UC_Attendee
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
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbYearLvl = new System.Windows.Forms.ComboBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(7, 97);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(358, 30);
            this.txtLName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(7, 37);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(358, 30);
            this.txtFName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "First Name";
            // 
            // txtCNumber
            // 
            this.txtCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNumber.Location = new System.Drawing.Point(7, 156);
            this.txtCNumber.Name = "txtCNumber";
            this.txtCNumber.Size = new System.Drawing.Size(358, 30);
            this.txtCNumber.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Year level";
            // 
            // cbYearLvl
            // 
            this.cbYearLvl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearLvl.Location = new System.Drawing.Point(7, 275);
            this.cbYearLvl.Name = "cbYearLvl";
            this.cbYearLvl.Size = new System.Drawing.Size(277, 31);
            this.cbYearLvl.TabIndex = 31;
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.White;
            this.butClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(140, 346);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(124, 34);
            this.butClear.TabIndex = 34;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.White;
            this.butAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(10, 346);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(124, 34);
            this.butAdd.TabIndex = 33;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(374, 73);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(713, 509);
            this.dataGridViewStudent.TabIndex = 35;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // butUpdate
            // 
            this.butUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(374, 588);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(124, 34);
            this.butUpdate.TabIndex = 37;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(504, 588);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(124, 34);
            this.butDelete.TabIndex = 36;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Department";
            // 
            // cbDept
            // 
            this.cbDept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDept.Location = new System.Drawing.Point(7, 215);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(358, 31);
            this.cbDept.TabIndex = 38;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(374, 37);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(333, 30);
            this.txtFilter.TabIndex = 40;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(370, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Filter";
            // 
            // UC_Attendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbYearLvl);
            this.Controls.Add(this.txtCNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label1);
            this.Name = "UC_Attendee";
            this.Size = new System.Drawing.Size(1109, 654);
            this.Load += new System.EventHandler(this.UC_Attendee_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UC_Attendee_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbYearLvl;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label6;
    }
}

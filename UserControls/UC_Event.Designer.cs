namespace EventAttendace.UserControls
{
    partial class UC_Event
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
            this.components = new System.ComponentModel.Container();
            this.butClear = new System.Windows.Forms.Button();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.White;
            this.butClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(780, 97);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(124, 34);
            this.butClear.TabIndex = 28;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(5, 235);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 51;
            this.dataGridViewEvents.RowTemplate.Height = 24;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1099, 348);
            this.dataGridViewEvents.TabIndex = 27;
            this.dataGridViewEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvents_CellClick);
            // 
            // butUpdate
            // 
            this.butUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(850, 195);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(124, 34);
            this.butUpdate.TabIndex = 26;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(980, 195);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(124, 34);
            this.butDelete.TabIndex = 25;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.White;
            this.butAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(650, 97);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(124, 34);
            this.butAdd.TabIndex = 24;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.Location = new System.Drawing.Point(389, 97);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(236, 31);
            this.cbCategory.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Event Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(7, 95);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(257, 32);
            this.dtpDate.TabIndex = 20;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(389, 38);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(358, 30);
            this.txtLocation.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Location";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(7, 38);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(358, 30);
            this.txtEventName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Event Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Event Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(7, 201);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(333, 30);
            this.txtFilter.TabIndex = 49;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // UC_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label1);
            this.Name = "UC_Event";
            this.Size = new System.Drawing.Size(1109, 654);
            this.Load += new System.EventHandler(this.UC_Event_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UC_Event_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilter;
    }
}

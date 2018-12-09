namespace StudentRecord
{
    partial class Form1
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.textboxFirst = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.textboxLast = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentLevel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(18, 9);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // textboxFirst
            // 
            this.textboxFirst.Location = new System.Drawing.Point(21, 25);
            this.textboxFirst.Name = "textboxFirst";
            this.textboxFirst.Size = new System.Drawing.Size(100, 20);
            this.textboxFirst.TabIndex = 1;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(18, 62);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(61, 13);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Name:";
            // 
            // textboxLast
            // 
            this.textboxLast.Location = new System.Drawing.Point(21, 78);
            this.textboxLast.Name = "textboxLast";
            this.textboxLast.Size = new System.Drawing.Size(100, 20);
            this.textboxLast.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 113);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID #:";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(21, 130);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(100, 20);
            this.textboxID.TabIndex = 5;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(23, 164);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level:";
            // 
            // comboLevel
            // 
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.comboLevel.Location = new System.Drawing.Point(21, 180);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(121, 21);
            this.comboLevel.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(21, 219);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(90, 23);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Save Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(21, 248);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(90, 23);
            this.btnEditStudent.TabIndex = 9;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(21, 278);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteStudent.TabIndex = 10;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(239, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(52, 13);
            this.lblStudents.TabIndex = 12;
            this.lblStudents.Text = "Students:";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(242, 30);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(210, 147);
            this.listBoxStudents.TabIndex = 13;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            this.listBoxStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStudents_MouseDoubleClick);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.lastName,
            this.studentID,
            this.currentLevel});
            this.dataGridStudents.Location = new System.Drawing.Point(21, 324);
            this.dataGridStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowTemplate.Height = 33;
            this.dataGridStudents.Size = new System.Drawing.Size(472, 119);
            this.dataGridStudents.TabIndex = 14;
            // 
            // FirstName
            // 
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.Frozen = true;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // studentID
            // 
            this.studentID.Frozen = true;
            this.studentID.HeaderText = "ID Number";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            // 
            // currentLevel
            // 
            this.currentLevel.Frozen = true;
            this.currentLevel.HeaderText = "Current Level";
            this.currentLevel.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.ReadOnly = true;
            this.currentLevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currentLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(242, 203);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 13);
            this.lblStudent.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 464);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textboxLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.textboxFirst);
            this.Controls.Add(this.lblFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Student Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox textboxFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox textboxLast;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewComboBoxColumn currentLevel;
        private System.Windows.Forms.Label lblStudent;
    }
}


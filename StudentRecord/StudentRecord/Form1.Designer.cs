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
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(36, 17);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(122, 25);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name:";
            // 
            // textboxFirst
            // 
            this.textboxFirst.Location = new System.Drawing.Point(42, 48);
            this.textboxFirst.Margin = new System.Windows.Forms.Padding(6);
            this.textboxFirst.Name = "textboxFirst";
            this.textboxFirst.Size = new System.Drawing.Size(196, 31);
            this.textboxFirst.TabIndex = 1;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(36, 119);
            this.lblLast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(121, 25);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Name:";
            // 
            // textboxLast
            // 
            this.textboxLast.Location = new System.Drawing.Point(42, 150);
            this.textboxLast.Margin = new System.Windows.Forms.Padding(6);
            this.textboxLast.Name = "textboxLast";
            this.textboxLast.Size = new System.Drawing.Size(196, 31);
            this.textboxLast.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(46, 217);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 25);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID #:";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(42, 250);
            this.textboxID.Margin = new System.Windows.Forms.Padding(6);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(196, 31);
            this.textboxID.TabIndex = 5;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(46, 315);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 25);
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
            this.comboLevel.Location = new System.Drawing.Point(42, 346);
            this.comboLevel.Margin = new System.Windows.Forms.Padding(6);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(238, 33);
            this.comboLevel.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(42, 421);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(180, 44);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Save Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(42, 477);
            this.btnEditStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(180, 44);
            this.btnEditStudent.TabIndex = 9;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(42, 535);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(180, 44);
            this.btnDeleteStudent.TabIndex = 10;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(478, 17);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(103, 25);
            this.lblStudents.TabIndex = 12;
            this.lblStudents.Text = "Students:";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 25;
            this.listBoxStudents.Location = new System.Drawing.Point(484, 58);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(416, 279);
            this.listBoxStudents.TabIndex = 13;
            this.listBoxStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStudents_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 652);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Student Record";
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
    }
}


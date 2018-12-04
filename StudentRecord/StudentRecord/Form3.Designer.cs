namespace StudentRecord
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.textboxClass = new System.Windows.Forms.TextBox();
            this.lblCurrentGrade = new System.Windows.Forms.Label();
            this.textboxCurrentGrade = new System.Windows.Forms.TextBox();
            this.lblGradeGoal = new System.Windows.Forms.Label();
            this.textboxGradeGoal = new System.Windows.Forms.TextBox();
            this.lblGradeWeight = new System.Windows.Forms.Label();
            this.textboxGradeWeight = new System.Windows.Forms.TextBox();
            this.btnGradeNeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID #:";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(25, 36);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(100, 20);
            this.textboxID.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(25, 77);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";
            // 
            // textboxClass
            // 
            this.textboxClass.Location = new System.Drawing.Point(25, 94);
            this.textboxClass.Name = "textboxClass";
            this.textboxClass.Size = new System.Drawing.Size(100, 20);
            this.textboxClass.TabIndex = 3;
            // 
            // lblCurrentGrade
            // 
            this.lblCurrentGrade.AutoSize = true;
            this.lblCurrentGrade.Location = new System.Drawing.Point(25, 136);
            this.lblCurrentGrade.Name = "lblCurrentGrade";
            this.lblCurrentGrade.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentGrade.TabIndex = 4;
            this.lblCurrentGrade.Text = "Current Grade:";
            // 
            // textboxCurrentGrade
            // 
            this.textboxCurrentGrade.Location = new System.Drawing.Point(117, 136);
            this.textboxCurrentGrade.Name = "textboxCurrentGrade";
            this.textboxCurrentGrade.Size = new System.Drawing.Size(100, 20);
            this.textboxCurrentGrade.TabIndex = 5;
            // 
            // lblGradeGoal
            // 
            this.lblGradeGoal.AutoSize = true;
            this.lblGradeGoal.Location = new System.Drawing.Point(25, 175);
            this.lblGradeGoal.Name = "lblGradeGoal";
            this.lblGradeGoal.Size = new System.Drawing.Size(64, 13);
            this.lblGradeGoal.TabIndex = 6;
            this.lblGradeGoal.Text = "Grade Goal:";
            // 
            // textboxGradeGoal
            // 
            this.textboxGradeGoal.Location = new System.Drawing.Point(117, 167);
            this.textboxGradeGoal.Name = "textboxGradeGoal";
            this.textboxGradeGoal.Size = new System.Drawing.Size(100, 20);
            this.textboxGradeGoal.TabIndex = 7;
            // 
            // lblGradeWeight
            // 
            this.lblGradeWeight.AutoSize = true;
            this.lblGradeWeight.Location = new System.Drawing.Point(25, 208);
            this.lblGradeWeight.Name = "lblGradeWeight";
            this.lblGradeWeight.Size = new System.Drawing.Size(76, 13);
            this.lblGradeWeight.TabIndex = 8;
            this.lblGradeWeight.Text = "Grade Weight:";
            // 
            // textboxGradeWeight
            // 
            this.textboxGradeWeight.Location = new System.Drawing.Point(117, 201);
            this.textboxGradeWeight.Name = "textboxGradeWeight";
            this.textboxGradeWeight.Size = new System.Drawing.Size(100, 20);
            this.textboxGradeWeight.TabIndex = 9;
            // 
            // btnGradeNeed
            // 
            this.btnGradeNeed.Location = new System.Drawing.Point(44, 251);
            this.btnGradeNeed.Name = "btnGradeNeed";
            this.btnGradeNeed.Size = new System.Drawing.Size(134, 23);
            this.btnGradeNeed.TabIndex = 10;
            this.btnGradeNeed.Text = "Calculate grade needed";
            this.btnGradeNeed.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 327);
            this.Controls.Add(this.btnGradeNeed);
            this.Controls.Add(this.textboxGradeWeight);
            this.Controls.Add(this.lblGradeWeight);
            this.Controls.Add(this.textboxGradeGoal);
            this.Controls.Add(this.lblGradeGoal);
            this.Controls.Add(this.textboxCurrentGrade);
            this.Controls.Add(this.lblCurrentGrade);
            this.Controls.Add(this.textboxClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox textboxClass;
        private System.Windows.Forms.Label lblCurrentGrade;
        private System.Windows.Forms.TextBox textboxCurrentGrade;
        private System.Windows.Forms.Label lblGradeGoal;
        private System.Windows.Forms.TextBox textboxGradeGoal;
        private System.Windows.Forms.Label lblGradeWeight;
        private System.Windows.Forms.TextBox textboxGradeWeight;
        private System.Windows.Forms.Button btnGradeNeed;
    }
}
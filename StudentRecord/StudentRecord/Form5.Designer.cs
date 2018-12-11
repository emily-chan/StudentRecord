namespace StudentRecord
{
    partial class FinalGradeCalc
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
            this.lblCurrentGrade = new System.Windows.Forms.Label();
            this.lblFinalWeight = new System.Windows.Forms.Label();
            this.lblGradeGoal = new System.Windows.Forms.Label();
            this.textBoxCurrGrade = new System.Windows.Forms.TextBox();
            this.textBoxFinalWeight = new System.Windows.Forms.TextBox();
            this.textBoxGradeGoal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFinalNeed = new System.Windows.Forms.Label();
            this.lblGradeNeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentGrade
            // 
            this.lblCurrentGrade.AutoSize = true;
            this.lblCurrentGrade.Location = new System.Drawing.Point(37, 38);
            this.lblCurrentGrade.Name = "lblCurrentGrade";
            this.lblCurrentGrade.Size = new System.Drawing.Size(121, 13);
            this.lblCurrentGrade.TabIndex = 0;
            this.lblCurrentGrade.Text = "Enter current grade (%): ";
            // 
            // lblFinalWeight
            // 
            this.lblFinalWeight.AutoSize = true;
            this.lblFinalWeight.Location = new System.Drawing.Point(37, 120);
            this.lblFinalWeight.Name = "lblFinalWeight";
            this.lblFinalWeight.Size = new System.Drawing.Size(108, 13);
            this.lblFinalWeight.TabIndex = 1;
            this.lblFinalWeight.Text = "Enter final weight (%):";
            // 
            // lblGradeGoal
            // 
            this.lblGradeGoal.AutoSize = true;
            this.lblGradeGoal.Location = new System.Drawing.Point(37, 79);
            this.lblGradeGoal.Name = "lblGradeGoal";
            this.lblGradeGoal.Size = new System.Drawing.Size(105, 13);
            this.lblGradeGoal.TabIndex = 2;
            this.lblGradeGoal.Text = "Enter grade goal (%):";
            // 
            // textBoxCurrGrade
            // 
            this.textBoxCurrGrade.Location = new System.Drawing.Point(192, 35);
            this.textBoxCurrGrade.Name = "textBoxCurrGrade";
            this.textBoxCurrGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrGrade.TabIndex = 3;
            // 
            // textBoxFinalWeight
            // 
            this.textBoxFinalWeight.Location = new System.Drawing.Point(192, 117);
            this.textBoxFinalWeight.Name = "textBoxFinalWeight";
            this.textBoxFinalWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinalWeight.TabIndex = 5;
            // 
            // textBoxGradeGoal
            // 
            this.textBoxGradeGoal.Location = new System.Drawing.Point(192, 76);
            this.textBoxGradeGoal.Name = "textBoxGradeGoal";
            this.textBoxGradeGoal.Size = new System.Drawing.Size(100, 20);
            this.textBoxGradeGoal.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(192, 163);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(67, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFinalNeed
            // 
            this.lblFinalNeed.AutoSize = true;
            this.lblFinalNeed.Location = new System.Drawing.Point(54, 220);
            this.lblFinalNeed.Name = "lblFinalNeed";
            this.lblFinalNeed.Size = new System.Drawing.Size(104, 13);
            this.lblFinalNeed.TabIndex = 8;
            this.lblFinalNeed.Text = "Final grade needed: ";
            // 
            // lblGradeNeed
            // 
            this.lblGradeNeed.AutoSize = true;
            this.lblGradeNeed.Location = new System.Drawing.Point(192, 220);
            this.lblGradeNeed.Name = "lblGradeNeed";
            this.lblGradeNeed.Size = new System.Drawing.Size(0, 13);
            this.lblGradeNeed.TabIndex = 9;
            // 
            // FinalGradeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 288);
            this.Controls.Add(this.lblGradeNeed);
            this.Controls.Add(this.lblFinalNeed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBoxGradeGoal);
            this.Controls.Add(this.textBoxFinalWeight);
            this.Controls.Add(this.textBoxCurrGrade);
            this.Controls.Add(this.lblGradeGoal);
            this.Controls.Add(this.lblFinalWeight);
            this.Controls.Add(this.lblCurrentGrade);
            this.Name = "FinalGradeCalc";
            this.Text = "Final Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentGrade;
        private System.Windows.Forms.Label lblFinalWeight;
        private System.Windows.Forms.Label lblGradeGoal;
        private System.Windows.Forms.TextBox textBoxCurrGrade;
        private System.Windows.Forms.TextBox textBoxFinalWeight;
        private System.Windows.Forms.TextBox textBoxGradeGoal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFinalNeed;
        private System.Windows.Forms.Label lblGradeNeed;
    }
}
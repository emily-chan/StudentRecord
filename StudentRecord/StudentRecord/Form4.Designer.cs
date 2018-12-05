﻿namespace StudentRecord
{
    partial class Form4
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asgName = new System.Windows.Forms.Label();
            this.ptsR = new System.Windows.Forms.Label();
            this.totalPts = new System.Windows.Forms.Label();
            this.textBoxAsg = new System.Windows.Forms.TextBox();
            this.textBoxPtsP = new System.Windows.Forms.TextBox();
            this.textBoxPtsR = new System.Windows.Forms.TextBox();
            this.btnAA = new System.Windows.Forms.Button();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnEA = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // asgName
            // 
            this.asgName.AutoSize = true;
            this.asgName.Location = new System.Drawing.Point(8, 71);
            this.asgName.Name = "asgName";
            this.asgName.Size = new System.Drawing.Size(95, 13);
            this.asgName.TabIndex = 2;
            this.asgName.Text = "Assignment Name:";
            // 
            // ptsR
            // 
            this.ptsR.AutoSize = true;
            this.ptsR.Location = new System.Drawing.Point(5, 120);
            this.ptsR.Name = "ptsR";
            this.ptsR.Size = new System.Drawing.Size(85, 13);
            this.ptsR.TabIndex = 3;
            this.ptsR.Text = "Points Received";
            // 
            // totalPts
            // 
            this.totalPts.AutoSize = true;
            this.totalPts.Location = new System.Drawing.Point(132, 120);
            this.totalPts.Name = "totalPts";
            this.totalPts.Size = new System.Drawing.Size(108, 13);
            this.totalPts.TabIndex = 4;
            this.totalPts.Text = "Total Possible Points:";
            // 
            // textBoxAsg
            // 
            this.textBoxAsg.Location = new System.Drawing.Point(6, 86);
            this.textBoxAsg.Name = "textBoxAsg";
            this.textBoxAsg.Size = new System.Drawing.Size(110, 20);
            this.textBoxAsg.TabIndex = 5;
            // 
            // textBoxPtsP
            // 
            this.textBoxPtsP.Location = new System.Drawing.Point(135, 139);
            this.textBoxPtsP.Name = "textBoxPtsP";
            this.textBoxPtsP.Size = new System.Drawing.Size(110, 20);
            this.textBoxPtsP.TabIndex = 6;
            // 
            // textBoxPtsR
            // 
            this.textBoxPtsR.Location = new System.Drawing.Point(6, 139);
            this.textBoxPtsR.Name = "textBoxPtsR";
            this.textBoxPtsR.Size = new System.Drawing.Size(110, 20);
            this.textBoxPtsR.TabIndex = 7;
            // 
            // btnAA
            // 
            this.btnAA.Location = new System.Drawing.Point(8, 193);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(108, 23);
            this.btnAA.TabIndex = 8;
            this.btnAA.Text = "Add Assignment";
            this.btnAA.UseVisualStyleBackColor = true;
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(9, 251);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(108, 23);
            this.btnDA.TabIndex = 9;
            this.btnDA.Text = "Delete Assignment";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnEA
            // 
            this.btnEA.Location = new System.Drawing.Point(9, 222);
            this.btnEA.Name = "btnEA";
            this.btnEA.Size = new System.Drawing.Size(108, 23);
            this.btnEA.TabIndex = 10;
            this.btnEA.Text = "Edit Assignment";
            this.btnEA.UseVisualStyleBackColor = true;
            this.btnEA.Click += new System.EventHandler(this.btnEA_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Homework",
            "Participation",
            "Midterm",
            "Quizzes",
            "Final",
            "Projects"});
            this.comboBoxCategory.Location = new System.Drawing.Point(5, 25);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCategory.TabIndex = 12;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnEA);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.btnAA);
            this.Controls.Add(this.textBoxPtsR);
            this.Controls.Add(this.textBoxPtsP);
            this.Controls.Add(this.textBoxAsg);
            this.Controls.Add(this.totalPts);
            this.Controls.Add(this.ptsR);
            this.Controls.Add(this.asgName);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label asgName;
        private System.Windows.Forms.Label ptsR;
        private System.Windows.Forms.Label totalPts;
        private System.Windows.Forms.TextBox textBoxAsg;
        private System.Windows.Forms.TextBox textBoxPtsP;
        private System.Windows.Forms.TextBox textBoxPtsR;
        private System.Windows.Forms.Button btnAA;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnEA;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}
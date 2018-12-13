namespace StudentRecord
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAssignments = new System.Windows.Forms.Label();
            this.tabControlAssignments = new System.Windows.Forms.TabControl();
            this.tabHomework = new System.Windows.Forms.TabPage();
            this.listBoxHomework = new System.Windows.Forms.ListBox();
            this.tabParticipation = new System.Windows.Forms.TabPage();
            this.listBoxParticipation = new System.Windows.Forms.ListBox();
            this.tabMidterm = new System.Windows.Forms.TabPage();
            this.listBoxMidterm = new System.Windows.Forms.ListBox();
            this.tabQuizzes = new System.Windows.Forms.TabPage();
            this.listBoxQuizzes = new System.Windows.Forms.ListBox();
            this.tabFinal = new System.Windows.Forms.TabPage();
            this.listBoxFinal = new System.Windows.Forms.ListBox();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalcGrade = new System.Windows.Forms.Button();
            this.lblWeightError = new System.Windows.Forms.Label();
            this.lblcalcGrade = new System.Windows.Forms.Label();
            this.tabControlAssignments.SuspendLayout();
            this.tabHomework.SuspendLayout();
            this.tabParticipation.SuspendLayout();
            this.tabMidterm.SuspendLayout();
            this.tabQuizzes.SuspendLayout();
            this.tabFinal.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // asgName
            // 
            this.asgName.AutoSize = true;
            this.asgName.Location = new System.Drawing.Point(24, 135);
            this.asgName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.asgName.Name = "asgName";
            this.asgName.Size = new System.Drawing.Size(192, 25);
            this.asgName.TabIndex = 2;
            this.asgName.Text = "Assignment Name:";
            // 
            // ptsR
            // 
            this.ptsR.AutoSize = true;
            this.ptsR.Location = new System.Drawing.Point(24, 231);
            this.ptsR.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ptsR.Name = "ptsR";
            this.ptsR.Size = new System.Drawing.Size(174, 25);
            this.ptsR.TabIndex = 3;
            this.ptsR.Text = "Points Received:";
            // 
            // totalPts
            // 
            this.totalPts.AutoSize = true;
            this.totalPts.Location = new System.Drawing.Point(264, 231);
            this.totalPts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalPts.Name = "totalPts";
            this.totalPts.Size = new System.Drawing.Size(220, 25);
            this.totalPts.TabIndex = 4;
            this.totalPts.Text = "Total Possible Points:";
            // 
            // textBoxAsg
            // 
            this.textBoxAsg.Location = new System.Drawing.Point(24, 165);
            this.textBoxAsg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAsg.Name = "textBoxAsg";
            this.textBoxAsg.Size = new System.Drawing.Size(216, 31);
            this.textBoxAsg.TabIndex = 5;
            // 
            // textBoxPtsP
            // 
            this.textBoxPtsP.Location = new System.Drawing.Point(270, 267);
            this.textBoxPtsP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPtsP.Name = "textBoxPtsP";
            this.textBoxPtsP.Size = new System.Drawing.Size(216, 31);
            this.textBoxPtsP.TabIndex = 6;
            // 
            // textBoxPtsR
            // 
            this.textBoxPtsR.Location = new System.Drawing.Point(22, 267);
            this.textBoxPtsR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPtsR.Name = "textBoxPtsR";
            this.textBoxPtsR.Size = new System.Drawing.Size(216, 31);
            this.textBoxPtsR.TabIndex = 7;
            // 
            // btnAA
            // 
            this.btnAA.Location = new System.Drawing.Point(22, 381);
            this.btnAA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(222, 44);
            this.btnAA.TabIndex = 8;
            this.btnAA.Text = "Add Assignment";
            this.btnAA.UseVisualStyleBackColor = true;
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(270, 381);
            this.btnDA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(220, 44);
            this.btnDA.TabIndex = 9;
            this.btnDA.Text = "Delete Assignment";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Homework",
            "Participation",
            "Midterm",
            "Quizzes",
            "Final",
            "Projects"});
            this.comboBoxCategory.Location = new System.Drawing.Point(24, 58);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(214, 33);
            this.comboBoxCategory.TabIndex = 12;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(26, 27);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(99, 25);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // lblAssignments
            // 
            this.lblAssignments.AutoSize = true;
            this.lblAssignments.Location = new System.Drawing.Point(532, 58);
            this.lblAssignments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAssignments.Name = "lblAssignments";
            this.lblAssignments.Size = new System.Drawing.Size(141, 25);
            this.lblAssignments.TabIndex = 15;
            this.lblAssignments.Text = "Assignments:";
            // 
            // tabControlAssignments
            // 
            this.tabControlAssignments.Controls.Add(this.tabHomework);
            this.tabControlAssignments.Controls.Add(this.tabParticipation);
            this.tabControlAssignments.Controls.Add(this.tabMidterm);
            this.tabControlAssignments.Controls.Add(this.tabQuizzes);
            this.tabControlAssignments.Controls.Add(this.tabFinal);
            this.tabControlAssignments.Controls.Add(this.tabProjects);
            this.tabControlAssignments.Location = new System.Drawing.Point(538, 112);
            this.tabControlAssignments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControlAssignments.Name = "tabControlAssignments";
            this.tabControlAssignments.SelectedIndex = 0;
            this.tabControlAssignments.Size = new System.Drawing.Size(652, 344);
            this.tabControlAssignments.TabIndex = 17;
            // 
            // tabHomework
            // 
            this.tabHomework.Controls.Add(this.listBoxHomework);
            this.tabHomework.Location = new System.Drawing.Point(8, 39);
            this.tabHomework.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabHomework.Name = "tabHomework";
            this.tabHomework.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabHomework.Size = new System.Drawing.Size(636, 297);
            this.tabHomework.TabIndex = 0;
            this.tabHomework.Text = "Homework";
            this.tabHomework.UseVisualStyleBackColor = true;
            // 
            // listBoxHomework
            // 
            this.listBoxHomework.FormattingEnabled = true;
            this.listBoxHomework.ItemHeight = 25;
            this.listBoxHomework.Location = new System.Drawing.Point(0, 0);
            this.listBoxHomework.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxHomework.Name = "listBoxHomework";
            this.listBoxHomework.Size = new System.Drawing.Size(632, 304);
            this.listBoxHomework.TabIndex = 0;
            // 
            // tabParticipation
            // 
            this.tabParticipation.Controls.Add(this.listBoxParticipation);
            this.tabParticipation.Location = new System.Drawing.Point(8, 39);
            this.tabParticipation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabParticipation.Name = "tabParticipation";
            this.tabParticipation.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabParticipation.Size = new System.Drawing.Size(636, 297);
            this.tabParticipation.TabIndex = 1;
            this.tabParticipation.Text = "Participation";
            this.tabParticipation.UseVisualStyleBackColor = true;
            // 
            // listBoxParticipation
            // 
            this.listBoxParticipation.FormattingEnabled = true;
            this.listBoxParticipation.ItemHeight = 25;
            this.listBoxParticipation.Location = new System.Drawing.Point(0, 0);
            this.listBoxParticipation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxParticipation.Name = "listBoxParticipation";
            this.listBoxParticipation.Size = new System.Drawing.Size(632, 304);
            this.listBoxParticipation.TabIndex = 1;
            // 
            // tabMidterm
            // 
            this.tabMidterm.Controls.Add(this.listBoxMidterm);
            this.tabMidterm.Location = new System.Drawing.Point(8, 39);
            this.tabMidterm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabMidterm.Name = "tabMidterm";
            this.tabMidterm.Size = new System.Drawing.Size(636, 297);
            this.tabMidterm.TabIndex = 2;
            this.tabMidterm.Text = "Midterm";
            this.tabMidterm.UseVisualStyleBackColor = true;
            // 
            // listBoxMidterm
            // 
            this.listBoxMidterm.FormattingEnabled = true;
            this.listBoxMidterm.ItemHeight = 25;
            this.listBoxMidterm.Location = new System.Drawing.Point(0, 0);
            this.listBoxMidterm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxMidterm.Name = "listBoxMidterm";
            this.listBoxMidterm.Size = new System.Drawing.Size(632, 304);
            this.listBoxMidterm.TabIndex = 1;
            // 
            // tabQuizzes
            // 
            this.tabQuizzes.Controls.Add(this.listBoxQuizzes);
            this.tabQuizzes.Location = new System.Drawing.Point(8, 39);
            this.tabQuizzes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabQuizzes.Name = "tabQuizzes";
            this.tabQuizzes.Size = new System.Drawing.Size(636, 297);
            this.tabQuizzes.TabIndex = 3;
            this.tabQuizzes.Text = "Quizzes";
            this.tabQuizzes.UseVisualStyleBackColor = true;
            // 
            // listBoxQuizzes
            // 
            this.listBoxQuizzes.FormattingEnabled = true;
            this.listBoxQuizzes.ItemHeight = 25;
            this.listBoxQuizzes.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuizzes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxQuizzes.Name = "listBoxQuizzes";
            this.listBoxQuizzes.Size = new System.Drawing.Size(632, 304);
            this.listBoxQuizzes.TabIndex = 1;
            // 
            // tabFinal
            // 
            this.tabFinal.Controls.Add(this.listBoxFinal);
            this.tabFinal.Location = new System.Drawing.Point(8, 39);
            this.tabFinal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabFinal.Name = "tabFinal";
            this.tabFinal.Size = new System.Drawing.Size(636, 297);
            this.tabFinal.TabIndex = 4;
            this.tabFinal.Text = "Final";
            this.tabFinal.UseVisualStyleBackColor = true;
            // 
            // listBoxFinal
            // 
            this.listBoxFinal.FormattingEnabled = true;
            this.listBoxFinal.ItemHeight = 25;
            this.listBoxFinal.Location = new System.Drawing.Point(0, 0);
            this.listBoxFinal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxFinal.Name = "listBoxFinal";
            this.listBoxFinal.Size = new System.Drawing.Size(632, 304);
            this.listBoxFinal.TabIndex = 1;
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.listBoxProjects);
            this.tabProjects.Location = new System.Drawing.Point(8, 39);
            this.tabProjects.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(636, 297);
            this.tabProjects.TabIndex = 5;
            this.tabProjects.Text = "Projects";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 25;
            this.listBoxProjects.Location = new System.Drawing.Point(0, 0);
            this.listBoxProjects.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(640, 304);
            this.listBoxProjects.TabIndex = 1;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(280, 165);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(196, 31);
            this.textBoxWeight.TabIndex = 18;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(282, 135);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(124, 25);
            this.lblWeight.TabIndex = 19;
            this.lblWeight.Text = "Weight (%):";
            // 
            // btnCalcGrade
            // 
            this.btnCalcGrade.Location = new System.Drawing.Point(12, 612);
            this.btnCalcGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcGrade.Name = "btnCalcGrade";
            this.btnCalcGrade.Size = new System.Drawing.Size(468, 69);
            this.btnCalcGrade.TabIndex = 20;
            this.btnCalcGrade.Text = "Calculate Grade";
            this.btnCalcGrade.UseVisualStyleBackColor = true;
            this.btnCalcGrade.Click += new System.EventHandler(this.btnCalcGrade_Click);
            // 
            // lblWeightError
            // 
            this.lblWeightError.AutoSize = true;
            this.lblWeightError.Location = new System.Drawing.Point(64, 494);
            this.lblWeightError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWeightError.Name = "lblWeightError";
            this.lblWeightError.Size = new System.Drawing.Size(0, 25);
            this.lblWeightError.TabIndex = 21;
            // 
            // lblcalcGrade
            // 
            this.lblcalcGrade.AutoSize = true;
            this.lblcalcGrade.Location = new System.Drawing.Point(626, 626);
            this.lblcalcGrade.Name = "lblcalcGrade";
            this.lblcalcGrade.Size = new System.Drawing.Size(0, 25);
            this.lblcalcGrade.TabIndex = 22;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 1100);
            this.Controls.Add(this.lblcalcGrade);
            this.Controls.Add(this.lblWeightError);
            this.Controls.Add(this.btnCalcGrade);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.tabControlAssignments);
            this.Controls.Add(this.lblAssignments);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.btnAA);
            this.Controls.Add(this.textBoxPtsR);
            this.Controls.Add(this.textBoxPtsP);
            this.Controls.Add(this.textBoxAsg);
            this.Controls.Add(this.totalPts);
            this.Controls.Add(this.ptsR);
            this.Controls.Add(this.asgName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form4";
            this.Text = "Add Assignments";
            this.tabControlAssignments.ResumeLayout(false);
            this.tabHomework.ResumeLayout(false);
            this.tabParticipation.ResumeLayout(false);
            this.tabMidterm.ResumeLayout(false);
            this.tabQuizzes.ResumeLayout(false);
            this.tabFinal.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAssignments;
        private System.Windows.Forms.TabControl tabControlAssignments;
        private System.Windows.Forms.TabPage tabHomework;
        private System.Windows.Forms.ListBox listBoxHomework;
        private System.Windows.Forms.TabPage tabParticipation;
        private System.Windows.Forms.ListBox listBoxParticipation;
        private System.Windows.Forms.TabPage tabMidterm;
        private System.Windows.Forms.ListBox listBoxMidterm;
        private System.Windows.Forms.TabPage tabQuizzes;
        private System.Windows.Forms.ListBox listBoxQuizzes;
        private System.Windows.Forms.TabPage tabFinal;
        private System.Windows.Forms.ListBox listBoxFinal;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalcGrade;
        private System.Windows.Forms.Label lblWeightError;
        private System.Windows.Forms.Label lblcalcGrade;
    }
}
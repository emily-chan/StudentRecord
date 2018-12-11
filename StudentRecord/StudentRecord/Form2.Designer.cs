namespace StudentRecord
{
    partial class Form2
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
            this.lblTerm = new System.Windows.Forms.Label();
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.textboxClass = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.tabControlClass = new System.Windows.Forms.TabControl();
            this.tabFall = new System.Windows.Forms.TabPage();
            this.listboxFall = new System.Windows.Forms.ListBox();
            this.tabSpring = new System.Windows.Forms.TabPage();
            this.listboxSpring = new System.Windows.Forms.ListBox();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.lblClassNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnGpaCalculator = new System.Windows.Forms.Button();
            this.lblClassInfo = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.btnFinalGradeCalc = new System.Windows.Forms.Button();
            this.tabControlClass.SuspendLayout();
            this.tabFall.SuspendLayout();
            this.tabSpring.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(27, 9);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(34, 13);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "Term:";
            // 
            // comboTerm
            // 
            this.comboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTerm.FormattingEnabled = true;
            this.comboTerm.Items.AddRange(new object[] {
            "Fall",
            "Spring"});
            this.comboTerm.Location = new System.Drawing.Point(30, 26);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(121, 21);
            this.comboTerm.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(27, 95);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";
            // 
            // textboxClass
            // 
            this.textboxClass.Location = new System.Drawing.Point(30, 111);
            this.textboxClass.Name = "textboxClass";
            this.textboxClass.Size = new System.Drawing.Size(121, 20);
            this.textboxClass.TabIndex = 3;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(29, 436);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(110, 436);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClass.TabIndex = 10;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // tabControlClass
            // 
            this.tabControlClass.Controls.Add(this.tabFall);
            this.tabControlClass.Controls.Add(this.tabSpring);
            this.tabControlClass.Location = new System.Drawing.Point(219, 26);
            this.tabControlClass.Name = "tabControlClass";
            this.tabControlClass.SelectedIndex = 0;
            this.tabControlClass.Size = new System.Drawing.Size(199, 144);
            this.tabControlClass.TabIndex = 6;
            // 
            // tabFall
            // 
            this.tabFall.Controls.Add(this.listboxFall);
            this.tabFall.Location = new System.Drawing.Point(4, 22);
            this.tabFall.Name = "tabFall";
            this.tabFall.Padding = new System.Windows.Forms.Padding(3);
            this.tabFall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabFall.Size = new System.Drawing.Size(191, 118);
            this.tabFall.TabIndex = 0;
            this.tabFall.Text = "Fall";
            this.tabFall.UseVisualStyleBackColor = true;
            // 
            // listboxFall
            // 
            this.listboxFall.FormattingEnabled = true;
            this.listboxFall.Location = new System.Drawing.Point(-1, -1);
            this.listboxFall.Name = "listboxFall";
            this.listboxFall.Size = new System.Drawing.Size(197, 121);
            this.listboxFall.TabIndex = 0;
            // 
            // tabSpring
            // 
            this.tabSpring.Controls.Add(this.listboxSpring);
            this.tabSpring.Location = new System.Drawing.Point(4, 22);
            this.tabSpring.Name = "tabSpring";
            this.tabSpring.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpring.Size = new System.Drawing.Size(191, 118);
            this.tabSpring.TabIndex = 1;
            this.tabSpring.Text = "Spring";
            this.tabSpring.UseVisualStyleBackColor = true;
            // 
            // listboxSpring
            // 
            this.listboxSpring.FormattingEnabled = true;
            this.listboxSpring.Location = new System.Drawing.Point(-2, -1);
            this.listboxSpring.Name = "listboxSpring";
            this.listboxSpring.Size = new System.Drawing.Size(197, 121);
            this.listboxSpring.TabIndex = 0;
            this.listboxSpring.SelectedIndexChanged += new System.EventHandler(this.listboxSpring_SelectedIndexChanged);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(29, 474);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(75, 23);
            this.btnEditClass.TabIndex = 11;
            this.btnEditClass.Text = "Edit Class";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(110, 474);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(27, 65);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(62, 62);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(57, 20);
            this.textBoxYear.TabIndex = 2;
            // 
            // lblClassNumber
            // 
            this.lblClassNumber.AutoSize = true;
            this.lblClassNumber.Location = new System.Drawing.Point(27, 153);
            this.lblClassNumber.Name = "lblClassNumber";
            this.lblClassNumber.Size = new System.Drawing.Size(72, 13);
            this.lblClassNumber.TabIndex = 14;
            this.lblClassNumber.Text = "Class Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(30, 169);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(235, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Click Finish when you\'re done adding classes to open dashboard and add assignment" +
    "s";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(29, 370);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(219, 224);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(60, 13);
            this.lblCategories.TabIndex = 28;
            this.lblCategories.Text = "Categories:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(27, 288);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(58, 13);
            this.lblWeight.TabIndex = 26;
            this.lblWeight.Text = "Weight (%)";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(30, 304);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(109, 20);
            this.textBoxWeight.TabIndex = 6;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(30, 341);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(109, 23);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
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
            this.comboBoxCategory.Location = new System.Drawing.Point(30, 244);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 222);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Category:";
            // 
            // btnGpaCalculator
            // 
            this.btnGpaCalculator.Location = new System.Drawing.Point(33, 540);
            this.btnGpaCalculator.Margin = new System.Windows.Forms.Padding(2);
            this.btnGpaCalculator.Name = "btnGpaCalculator";
            this.btnGpaCalculator.Size = new System.Drawing.Size(286, 32);
            this.btnGpaCalculator.TabIndex = 13;
            this.btnGpaCalculator.Text = "Go to GPA calculator";
            this.btnGpaCalculator.UseVisualStyleBackColor = true;
            this.btnGpaCalculator.Click += new System.EventHandler(this.btnGpaCalculator_Click);
            // 
            // lblClassInfo
            // 
            this.lblClassInfo.AutoSize = true;
            this.lblClassInfo.Location = new System.Drawing.Point(219, 177);
            this.lblClassInfo.Name = "lblClassInfo";
            this.lblClassInfo.Size = new System.Drawing.Size(0, 13);
            this.lblClassInfo.TabIndex = 34;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(219, 240);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(191, 121);
            this.listBoxCategories.TabIndex = 35;
            // 
            // btnFinalGradeCalc
            // 
            this.btnFinalGradeCalc.Location = new System.Drawing.Point(33, 603);
            this.btnFinalGradeCalc.Name = "btnFinalGradeCalc";
            this.btnFinalGradeCalc.Size = new System.Drawing.Size(286, 35);
            this.btnFinalGradeCalc.TabIndex = 14;
            this.btnFinalGradeCalc.Text = "Final Grade Calculator";
            this.btnFinalGradeCalc.UseVisualStyleBackColor = true;
            this.btnFinalGradeCalc.Click += new System.EventHandler(this.btnFinalGradeCalc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 674);
            this.Controls.Add(this.btnFinalGradeCalc);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.lblClassInfo);
            this.Controls.Add(this.btnGpaCalculator);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.lblClassNumber);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.tabControlClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.textboxClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.comboTerm);
            this.Controls.Add(this.lblTerm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControlClass.ResumeLayout(false);
            this.tabFall.ResumeLayout(false);
            this.tabSpring.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ComboBox comboTerm;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox textboxClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.TabControl tabControlClass;
        private System.Windows.Forms.TabPage tabFall;
        private System.Windows.Forms.ListBox listboxFall;
        private System.Windows.Forms.TabPage tabSpring;
        private System.Windows.Forms.ListBox listboxSpring;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label lblClassNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnGpaCalculator;
        private System.Windows.Forms.Label lblClassInfo;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button btnFinalGradeCalc;
    }
}
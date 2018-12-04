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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlClass = new System.Windows.Forms.TabControl();
            this.tabFall = new System.Windows.Forms.TabPage();
            this.tabSpring = new System.Windows.Forms.TabPage();
            this.listboxFall = new System.Windows.Forms.ListBox();
            this.listboxSpring = new System.Windows.Forms.ListBox();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnGPA = new System.Windows.Forms.Button();
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
            this.lblClass.Location = new System.Drawing.Point(27, 65);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";
            // 
            // textboxClass
            // 
            this.textboxClass.Location = new System.Drawing.Point(30, 81);
            this.textboxClass.Name = "textboxClass";
            this.textboxClass.Size = new System.Drawing.Size(121, 20);
            this.textboxClass.TabIndex = 3;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(30, 122);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Class";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControlClass
            // 
            this.tabControlClass.Controls.Add(this.tabFall);
            this.tabControlClass.Controls.Add(this.tabSpring);
            this.tabControlClass.Location = new System.Drawing.Point(209, 12);
            this.tabControlClass.Name = "tabControlClass";
            this.tabControlClass.SelectedIndex = 0;
            this.tabControlClass.Size = new System.Drawing.Size(200, 148);
            this.tabControlClass.TabIndex = 6;
            // 
            // tabFall
            // 
            this.tabFall.Controls.Add(this.listboxFall);
            this.tabFall.Location = new System.Drawing.Point(4, 22);
            this.tabFall.Name = "tabFall";
            this.tabFall.Padding = new System.Windows.Forms.Padding(3);
            this.tabFall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabFall.Size = new System.Drawing.Size(192, 122);
            this.tabFall.TabIndex = 0;
            this.tabFall.Text = "Fall";
            this.tabFall.UseVisualStyleBackColor = true;
            // 
            // tabSpring
            // 
            this.tabSpring.Controls.Add(this.listboxSpring);
            this.tabSpring.Location = new System.Drawing.Point(4, 22);
            this.tabSpring.Name = "tabSpring";
            this.tabSpring.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpring.Size = new System.Drawing.Size(192, 122);
            this.tabSpring.TabIndex = 1;
            this.tabSpring.Text = "Spring";
            this.tabSpring.UseVisualStyleBackColor = true;
            // 
            // listboxFall
            // 
            this.listboxFall.FormattingEnabled = true;
            this.listboxFall.Location = new System.Drawing.Point(-1, 0);
            this.listboxFall.Name = "listboxFall";
            this.listboxFall.Size = new System.Drawing.Size(193, 121);
            this.listboxFall.TabIndex = 0;
            // 
            // listboxSpring
            // 
            this.listboxSpring.FormattingEnabled = true;
            this.listboxSpring.Location = new System.Drawing.Point(0, 0);
            this.listboxSpring.Name = "listboxSpring";
            this.listboxSpring.Size = new System.Drawing.Size(193, 121);
            this.listboxSpring.TabIndex = 0;
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(30, 159);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(75, 23);
            this.btnEditClass.TabIndex = 7;
            this.btnEditClass.Text = "Edit Class";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(30, 237);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnGPA
            // 
            this.btnGPA.Location = new System.Drawing.Point(30, 277);
            this.btnGPA.Name = "btnGPA";
            this.btnGPA.Size = new System.Drawing.Size(156, 23);
            this.btnGPA.TabIndex = 10;
            this.btnGPA.Text = "Calculate Cumulative GPA";
            this.btnGPA.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 355);
            this.Controls.Add(this.btnGPA);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.tabControlClass);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControlClass;
        private System.Windows.Forms.TabPage tabFall;
        private System.Windows.Forms.ListBox listboxFall;
        private System.Windows.Forms.TabPage tabSpring;
        private System.Windows.Forms.ListBox listboxSpring;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnGPA;
    }
}
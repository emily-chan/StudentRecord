using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecord
{
    public partial class FinalGradeCalc : Form
    {
        public FinalGradeCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double currentGrade = double.Parse(textBoxCurrGrade.Text) / 100;
            double gradeGoal = double.Parse(textBoxGradeGoal.Text) / 100;
            double finalWeight = double.Parse(textBoxFinalWeight.Text) / 100;
            double gradeNeed = (gradeGoal - currentGrade * (1 - finalWeight)) / finalWeight;
            double percentNeed = gradeNeed * 100;
            lblGradeNeed.Text = percentNeed.ToString() + "%";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxCurrGrade.Text = "";
            textBoxGradeGoal.Text = "";
            textBoxFinalWeight.Text = "";
            lblGradeNeed.Text = "";
        }
    }
}

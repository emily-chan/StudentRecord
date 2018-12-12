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
    public partial class GPACalculator : Form
    {
        static Form1 obj = new Form1();

        public GPACalculator()
        {
            InitializeComponent();
            comboBoxC1.SelectedIndex = 0;
            comboBoxC2.SelectedIndex = 0;
            comboBoxC3.SelectedIndex = 0;
            comboBoxC4.SelectedIndex = 0;
            comboBoxC5.SelectedIndex = 0;
            comboBoxC6.SelectedIndex = 0;
            comboBoxC7.SelectedIndex = 0;

            comboBoxG1.SelectedIndex = 0;
            comboBoxG2.SelectedIndex = 0;
            comboBoxG3.SelectedIndex = 0;
            comboBoxG4.SelectedIndex = 0;
            comboBoxG5.SelectedIndex = 0; 
            comboBoxG6.SelectedIndex = 0;
            comboBoxG7.SelectedIndex = 0;

        }
        
        // get numeric score based on corresponding letter grade
        public double GetScore(string grade)
        {
            double score = 0.0;
            if (grade.Equals("A+") || grade.Equals("A"))
            {
                score = 4.0;
            }
            else if (grade.Equals("A-"))
            {
                score = 3.7;
            }
            else if (grade.Equals("B+"))
            {
                score = 3.3;
            }
            else if (grade.Equals("B"))
            {
                score = 3.0;
            }
            else if (grade.Equals("B-"))
            {
                score = 2.7;
            }
            else if (grade.Equals("C+"))
            {
                score = 2.3;
            }
            else if (grade.Equals("C"))
            {
                score = 2.0;
            }
            else if (grade.Equals("C-"))
            {
                score = 1.7;
            }
            else if (grade.Equals("D+"))
            {
                score = 1.3;
            }
            else if (grade.Equals("D"))
            {
                score = 1.0;
            }
            else if (grade.Equals("F"))
            {
                score = 0.0;
            }
            return score;
        }

        private void btnCalcGPA_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, c4, c5, c6, c7; // credits from combobox
            double w1, w2, w3, w4, w5, w6, w7; // weight of credits
            String g1, g2, g3, g4, g5, g6, g7; // grades from combobox
            double Gpa = 0.0;
             
            //convert credits to double value
            c1 = double.Parse(comboBoxC1.SelectedItem.ToString());
            c2 = double.Parse(comboBoxC2.SelectedItem.ToString());
            c3 = double.Parse(comboBoxC3.SelectedItem.ToString());
            c4 = double.Parse(comboBoxC4.SelectedItem.ToString());
            c5 = double.Parse(comboBoxC5.SelectedItem.ToString());
            c6 = double.Parse(comboBoxC6.SelectedItem.ToString());
            c7 = double.Parse(comboBoxC7.SelectedItem.ToString());

            //calculate total credits
            List<double> credits = new List<double>();
            credits.Add(c1);
            credits.Add(c2);
            credits.Add(c3);
            credits.Add(c4);
            credits.Add(c5);
            credits.Add(c6);
            credits.Add(c7);

            double totalCredits = credits.Sum();
            
            // find weight of each class
            w1 = c1 / totalCredits;
            w2 = c2 / totalCredits;
            w3 = c3 / totalCredits;
            w4 = c4 / totalCredits;
            w5 = c5 / totalCredits;
            w6 = c6 / totalCredits;
            w7 = c7 / totalCredits;

            List<double> weights = new List<double>();
            weights.Add(w1);
            weights.Add(w2);
            weights.Add(w3);
            weights.Add(w4);
            weights.Add(w5);
            weights.Add(w6);
            weights.Add(w7);

            //convert grades to string
            g1 = comboBoxG1.SelectedItem.ToString();
            g2 = comboBoxG2.SelectedItem.ToString();
            g3 = comboBoxG3.SelectedItem.ToString();
            g4 = comboBoxG4.SelectedItem.ToString();
            g5 = comboBoxG5.SelectedItem.ToString();
            g6 = comboBoxG6.SelectedItem.ToString();
            g7 = comboBoxG7.SelectedItem.ToString();

            // sum of weighted scores for each class 
            Gpa = (w1 * GetScore(g1)) + (w2 * GetScore(g2)) + (w3 * GetScore(g3)) + (w4 * GetScore(g4)) + (w5 * GetScore(g5)) + (w6 * GetScore(g6)) + (w7 * GetScore(g7));
            
            lblGPAResult.Text = Gpa.ToString();
            lblCredits.Text = totalCredits.ToString();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxC1.SelectedIndex = 0;
            comboBoxC2.SelectedIndex = 0;
            comboBoxC3.SelectedIndex = 0;
            comboBoxC4.SelectedIndex = 0;
            comboBoxC5.SelectedIndex = 0;
            comboBoxC6.SelectedIndex = 0;
            comboBoxC7.SelectedIndex = 0;

            comboBoxG1.SelectedIndex = 0;
            comboBoxG2.SelectedIndex = 0;
            comboBoxG3.SelectedIndex = 0;
            comboBoxG4.SelectedIndex = 0;
            comboBoxG5.SelectedIndex = 0;
            comboBoxG6.SelectedIndex = 0;
            comboBoxG7.SelectedIndex = 0;

            lblCredits.Text = "";
            lblGPAResult.Text = "";
           
        }
    }
}


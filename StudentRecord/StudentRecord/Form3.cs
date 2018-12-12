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
        }

        // calculate grade weight
         //weight = credit amount/total number of credits
        public double? CalcWeight(double? weight, double? total)
        {
            double? gradeWeight = weight / total;
            return gradeWeight;
        }

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
            int c1, c2, c3, c4, c5, c6, c7; // credits from combobox
            double? w1, w2, w3, w4, w5, w6, w7; // weight of credits
            String g1, g2, g3, g4, g5, g6, g7; // grades from combobox
            double? Gpa = 0.0;

            //convert credits to int value
            c1 = int.Parse(comboBoxC1.SelectedIndex.ToString());
            c2 = int.Parse(comboBoxC2.SelectedIndex.ToString());
            c3 = int.Parse(comboBoxC3.SelectedIndex.ToString());
            c4 = int.Parse(comboBoxC4.SelectedIndex.ToString());
            c5 = int.Parse(comboBoxC5.SelectedIndex.ToString());
            c6 = int.Parse(comboBoxC6.SelectedIndex.ToString());
            c7 = int.Parse(comboBoxC7.SelectedIndex.ToString());

            //calculate total credits
            //int[] credits = { c1, c2, c3, c4, c5, c6, c7 };
            var credits = new List<double?> { c1, c2, c3, c4, c5, c6, c7};
            /*credits.Add(c1);
            credits.Add(c2);
            credits.Add(c3);
            credits.Add(c4);
            credits.Add(c5);
            credits.Add(c6);
            credits.Add(c7);*/

            double? totalCredits = credits.Sum();

            //int totalCredits = 0;
           /* foreach (int c in credits)
            {
                totalCredits = totalCredits + c;
            }*/
            
            w1 = c1 / totalCredits;
            w2 = c2 / totalCredits;
            w3 = c3 / totalCredits;
            w4 = c4 / totalCredits;
            w5 = c5 / totalCredits;
            w6 = c6 / totalCredits;
            w7 = c7 / totalCredits;

            var weights = new List<double?> { w1, w2, w3, w4, w5, w6, w7 };

            /*List<double> weights = new List<double>();
            weights.Add(w1);
            weights.Add(w2);
            weights.Add(w3);
            weights.Add(w4);
            weights.Add(w5);
            weights.Add(w6);
            weights.Add(w7);*/


            //convert grades to string
            g1 = comboBoxG1.SelectedIndex.ToString();
            g2 = comboBoxG2.SelectedIndex.ToString();
            g3 = comboBoxG3.SelectedIndex.ToString();
            g4 = comboBoxG4.SelectedIndex.ToString();
            g5 = comboBoxG5.SelectedIndex.ToString();
            g6 = comboBoxG6.SelectedIndex.ToString();
            g7 = comboBoxG7.SelectedIndex.ToString();

           // String[] grades = { g1, g2, g3, g4, g5, g6, g7 };
            List<String> grades = new List<String>();


            grades.Add(g1);
            grades.Add(g2);
            grades.Add(g3);
            grades.Add(g4);
            grades.Add(g5);
            grades.Add(g6);
            grades.Add(g7);

            double score = 0.0;
            double? gradeWeight = 0.0;
            double? totalWeight = 0.0; 
            //double totalScore = 0.0;
          
            foreach(double? w in weights)
            {
                gradeWeight = CalcWeight(w, totalCredits);
                
                totalWeight = gradeWeight*score;
            }
            Gpa += totalWeight;

                //totalScore = totalScore + score;

            Gpa = (w1 * GetScore(g1)) + (w2 * GetScore(g2)) + (w3 * GetScore(g3)) + (w4 * GetScore(g4)) + (w5 * GetScore(g5)) + (w6 * GetScore(g6)) + (w7 * GetScore(g7));


            //double finalScore = 0;
            //finalScore = totalScore * totalCredits;
            





            Console.WriteLine(Gpa);
           

            //Gpa = finalScore / totalCredits;
            lblGPAResult.Text = Gpa.ToString();
            lblCredits.Text = totalCredits.ToString();

            lblw1.Text = totalWeight.ToString();

        }
    }
}


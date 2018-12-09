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

        private void btnCalcGPA_Click(object sender, EventArgs e)
        {
            int c1, c2, c3, c4, c5, c6, c7;
            String g1, g2, g3, g4, g5, g6, g7;
            int totalClasses = 0;
            double Gpa = 0.0;

            //convert credits to int value
            c1 = int.Parse(comboBoxC1.SelectedIndex.ToString());
            c2 = int.Parse(comboBoxC2.SelectedIndex.ToString());
            c3 = int.Parse(comboBoxC3.SelectedIndex.ToString());
            c4 = int.Parse(comboBoxC4.SelectedIndex.ToString());
            c5 = int.Parse(comboBoxC5.SelectedIndex.ToString());
            c6 = int.Parse(comboBoxC6.SelectedIndex.ToString());
            c7 = int.Parse(comboBoxC7.SelectedIndex.ToString());

            g1 = comboBoxG1.SelectedIndex.ToString();
            g2 = comboBoxG2.SelectedIndex.ToString();
            g3 = comboBoxG3.SelectedIndex.ToString();
            g4 = comboBoxG4.SelectedIndex.ToString();
            g5 = comboBoxG5.SelectedIndex.ToString();
            g6 = comboBoxG6.SelectedIndex.ToString();
            g7 = comboBoxG7.SelectedIndex.ToString();

            String[] grades = { g1, g2, g3, g4, g5, g6, g7};


                double score = 0.0;
                double totalScore = 0.0;
                foreach (String grade in grades)
                {
                    if (grade == "A +")
                    {
                        score += 4.0;
                    }

                    else if (grade == "A ")
                    {
                        score += 4.0;
                    }
                    else if (grade == "A -")
                    {
                        score += 3.7;
                    }
                    else if (grade == "B +")
                    {
                        score += 3.3;
                    }
                    else if (grade == "B ")
                    {
                        score += 3.0;
                    }
                    else if (grade == "B -")
                    {
                        score += 2.7;
                    }
                    else if (grade == "C +")
                    {
                        score += 2.3;
                    }
                    else if (grade == "C ")
                    {
                        score += 2.0;
                    }
                    else if (grade == "C -")
                    {
                        score += 1.7;
                    }
                    else if (grade == "D +")
                    {
                        score += 1.3;
                    }
                    else if (grade == "D ")
                    {
                        score += 1.0;
                    }
                    else if (grade == "F ")
                    {
                        score += 0.0;
                    }

                    totalScore = totalScore + score;

                for(int i = 1; i < grades.Length; i++)
                {
                    totalClasses += 1; 
                   
                }

                Gpa = totalScore / totalClasses; 


               
                }
            
            txtboxResultGPA.Text = Gpa.ToString("0.0"); 




            

       
        }

    }
}

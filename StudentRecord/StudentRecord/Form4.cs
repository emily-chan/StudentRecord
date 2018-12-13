using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentRecord
{
    public partial class Form4 : Form
    {
        //public static BindingList<Assignment> assignments = new BindingList<Assignment>();
        static BindingList<Assignment> homework = new BindingList<Assignment>();
        static BindingList<Assignment> participation = new BindingList<Assignment>();
        static BindingList<Assignment> midterm = new BindingList<Assignment>();
        static BindingList<Assignment> quizzes = new BindingList<Assignment>();
        static BindingList<Assignment> final = new BindingList<Assignment>();
        static BindingList<Assignment> projects = new BindingList<Assignment>();
        public double pointsHW, pointsPart, pointsMidterm, pointsQuizzes, pointsFinal, pointsProjects;
        public double totalPointsHW, totalPointsPart, totalPointsMidterm, totalPointsQuizzes, totalPointsFinal, totalPointsProjects;
        public double gradeHW, gradePart, gradeMidterm, gradeQuizzes, gradeFinal, gradeProjects;
        double weight;
        double pointsReceived, totalPoints;
        double HWPerc, partPerc, midtermPerc, finalPerc, quizzesPerc, projectPerc;
        public List<double> allWeights = new List<double>();

        public Form4()
        {
           
            //LoadRecord();
            InitializeComponent();
            BindListBox();
        }
        private void BindListBox()
        {
            listBoxHomework.DataSource = homework;
            listBoxHomework.DisplayMember = "displayAssignment";
            listBoxParticipation.DataSource = participation;
            listBoxParticipation.DisplayMember = "displayAssignment";
            listBoxMidterm.DataSource = midterm;
            listBoxMidterm.DisplayMember = "displayAssignment";
            listBoxQuizzes.DataSource = quizzes;
            listBoxQuizzes.DisplayMember = "displayAssignment";
            listBoxFinal.DataSource = final;
            listBoxFinal.DisplayMember = "displayAssignment";
            listBoxProjects.DataSource = projects;
            listBoxProjects.DisplayMember = "displayAssignment";

            //listBoxAssignments.DataSource = assignments;
            //listBoxAssignments.DisplayMember = "displayAssignment";
            //dataGridAssignments.DataSource = assignments;
            //dataGridAssignments.ColumnAsg = "displayAssignmentName";
        }
        //add Assignment

        private void btnAA_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();
            
            Assignment a;
            
            
            if (category.Equals("Homework"))
            {
                a = new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Homework",
                    weight = textBoxWeight.Text,
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    
                    //percentage = calculatePercentage()
                };

                
                homework.Add(a);
                // add category weight to list of weights (used to check if it adds up to 100)
                weight = double.Parse(textBoxWeight.Text);
                allWeights.Add(weight);
                tabControlAssignments.SelectedTab = tabHomework;

                pointsReceived = double.Parse(textBoxPtsR.Text);
                pointsHW += pointsReceived;

                totalPoints = double.Parse(textBoxPtsP.Text);
                totalPointsHW += totalPoints;

                
                HWPerc = ((pointsHW / totalPointsHW) * 100) * weight;

            }
            else if (category.Equals("Participation"))
            {
                a = new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Participation",
                    weight = textBoxWeight.Text,
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()

                };

                participation.Add(a);
                weight = double.Parse(textBoxWeight.Text);
                allWeights.Add(weight);
                tabControlAssignments.SelectedTab = tabParticipation;

                pointsReceived = double.Parse(textBoxPtsR.Text);
                pointsPart += pointsReceived;

                totalPoints = double.Parse(textBoxPtsP.Text);
                totalPointsPart += totalPoints;

              
                partPerc = ((pointsPart / totalPointsPart) * 100) * weight;
            }
            else if (category.Equals("Midterm"))
            {
                a = new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Midterm",
                    weight = textBoxWeight.Text,
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    

                };
                midterm.Add(a);
                weight = double.Parse(textBoxWeight.Text);
                allWeights.Add(weight);
                tabControlAssignments.SelectedTab = tabMidterm;

                pointsReceived = double.Parse(textBoxPtsR.Text);
                pointsMidterm += pointsReceived;

                totalPoints = double.Parse(textBoxPtsP.Text);
                totalPointsMidterm += totalPoints;

                
                midtermPerc = ((pointsMidterm / totalPointsMidterm) * 100) * weight;

            }
            else if (category.Equals("Quizzes"))
            {
                a = new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Quizzes",
                    weight = textBoxWeight.Text,
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()

                };
                quizzes.Add(a);
                weight = double.Parse(textBoxWeight.Text);
                allWeights.Add(weight);
                tabControlAssignments.SelectedTab = tabQuizzes;

                pointsReceived = double.Parse(textBoxPtsR.Text);
                pointsQuizzes += pointsReceived;

                totalPoints = double.Parse(textBoxPtsP.Text);
                totalPointsQuizzes += totalPoints;

              
                quizzesPerc = ((pointsQuizzes / totalPointsQuizzes) * 100) * weight;
            }
            else if (category.Equals("Final"))
            {
                a = new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Final",
                    weight = textBoxWeight.Text,
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()

                };
                final.Add(a);
                weight = double.Parse(textBoxWeight.Text);
                allWeights.Add(weight);
                tabControlAssignments.SelectedTab = tabFinal;

                pointsReceived = double.Parse(textBoxPtsR.Text);
                pointsFinal += pointsReceived;

                totalPoints = double.Parse(textBoxPtsP.Text);
                totalPointsFinal += totalPoints;

                finalPerc = ((pointsFinal / totalPointsFinal)*100) * weight;
            }
            else if (category.Equals("Projects"))
            {
                a = new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Projects",
                    weight = textBoxWeight.Text,
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()

                };
                projects.Add(a);
                weight = double.Parse(textBoxWeight.Text);
                allWeights.Add(weight);
                tabControlAssignments.SelectedTab = tabProjects;

                pointsReceived = double.Parse(textBoxPtsR.Text);
                pointsProjects += pointsReceived;

                totalPoints = double.Parse(textBoxPtsP.Text);
                totalPointsProjects += totalPoints;

                
                projectPerc = ((pointsProjects / totalPointsProjects) * 100) * weight;

            }
            if (allWeights.Sum() > 100)
            {
                lblWeightError.Text = "The category weights you entered do not add up to 100%. Please fix this.";
            }

            //WriteRecord();
        }


        private void btnDA_Click(object sender, EventArgs e)
        {
            if (tabControlAssignments.SelectedTab == tabHomework && listBoxHomework.SelectedIndex > -1)
            {
                homework.RemoveAt(listBoxHomework.SelectedIndex);
            }
            else if (tabControlAssignments.SelectedTab == tabParticipation && listBoxParticipation.SelectedIndex > -1)
            {
                participation.RemoveAt(listBoxParticipation.SelectedIndex);
            }
            else if (tabControlAssignments.SelectedTab == tabMidterm && listBoxMidterm.SelectedIndex > -1)
            {
                midterm.RemoveAt(listBoxMidterm.SelectedIndex);
            }
            else if (tabControlAssignments.SelectedTab == tabQuizzes && listBoxQuizzes.SelectedIndex > -1)
            {
                quizzes.RemoveAt(listBoxQuizzes.SelectedIndex);
            }
            else if (tabControlAssignments.SelectedTab == tabFinal && listBoxFinal.SelectedIndex > -1)
            {
                final.RemoveAt(listBoxFinal.SelectedIndex);
            }
            else if (tabControlAssignments.SelectedTab == tabProjects && listBoxProjects.SelectedIndex > -1)
            {
                projects.RemoveAt(listBoxProjects.SelectedIndex);
            }
           

            //WriteRecord();
        }

       
        private void btnCalcGrade_Click(object sender, EventArgs e)
        {
            double allGrades = (HWPerc + partPerc + quizzesPerc + midtermPerc + finalPerc + projectPerc)/ allWeights.Sum();
            lblcalcGrade.Text = allGrades.ToString(); 
        }

        //serialization part

        /*
    public static void WriteRecord()
    {
        //serialization-xml
        XmlSerializer serializerW = new XmlSerializer(typeof(BindingList<Assignment>));
        TextWriter writer = new StreamWriter("serialized.xml");
        serializerW.Serialize(writer, assignments);
        writer.Close();
    }
    public static void LoadRecord()
    {
        try
        {
            //deserialization-xml
            XmlSerializer serializerR = new XmlSerializer(typeof(BindingList<Student>));
            TextReader reader = new StreamReader("serialized.xml");
            assignments = (BindingList<Assignment>)serializerR.Deserialize(reader);
            reader.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Error");
        }
    }
    */


    }

}

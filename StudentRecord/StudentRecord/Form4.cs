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
        public static BindingList<Assignment> assignments = new BindingList<Assignment>();
        static BindingList<Assignment> homework = new BindingList<Assignment>();
        static BindingList<Assignment> participation = new BindingList<Assignment>();
        static BindingList<Assignment> midterm = new BindingList<Assignment>();
        static BindingList<Assignment> quizzes = new BindingList<Assignment>();
        static BindingList<Assignment> final = new BindingList<Assignment>();
        static BindingList<Assignment> projects = new BindingList<Assignment>();
        public double pointsHW, pointsPart, pointsMidterm, pointsQuizzes, pointsFinal, pointsProjects;
        public double totalPointsHW, totalPointsPart, totalPointsMidterm, totalPointsQuizzes, totalPointsFinal, totalPointsProjects;
        public double gradeHW, gradePart, gradeMidterm, gradeQuizzes, gradeFinal, gradeProjects;


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
                tabControlAssignments.SelectedTab = tabHomework;
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
                tabControlAssignments.SelectedTab = tabParticipation;
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
                tabControlAssignments.SelectedTab = tabMidterm;
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
                tabControlAssignments.SelectedTab = tabQuizzes;
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
                tabControlAssignments.SelectedTab = tabFinal;
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
                tabControlAssignments.SelectedTab = tabProjects;

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
            else if (tabControlAssignments.SelectedTab == tabParticipation && listBoxParticipation.SelectedIndex > -1)
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

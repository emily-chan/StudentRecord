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
        
        public Form4()
        {
           
            //LoadRecord();
            InitializeComponent();
            BindListBox();
        }
        private void BindListBox()
        {
            listBoxAssignments.DataSource = assignments;
            listBoxAssignments.DisplayMember = "displayAssignments";
            //dataGridAssignments.DataSource = assignments;
            //dataGridAssignments.ColumnAsg = "displayAssignmentName";
        }
        //add Assignment

        private void btnAA_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();

            if (category.Equals("Homework"))
            {
                assignments.Add(new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Homework",
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()

                });

            }
            else if (category.Equals("Participation"))
            {

                assignments.Add(new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Participation",
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()
                });

            }
            else if (category.Equals("Midterm"))
            {

                assignments.Add(new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Midterm",
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()
                });

            }
            else if (category.Equals("Quizzes"))
            {

                assignments.Add(new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Quizzes",
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()
                });

            }

            else if (category.Equals("Final"))
            {

                assignments.Add(new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Final",
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()
                });

            }
            else if (category.Equals("Projects"))
            {

                assignments.Add(new Assignment()
                {
                    assignmentName = textBoxAsg.Text,
                    category = "Projects",
                    pointsReceived = textBoxPtsR.Text,
                    totalPoints = textBoxPtsP.Text,
                    //percentage = calculatePercentage()
                });

            }
            //WriteRecord();
        }


        private void btnDA_Click(object sender, EventArgs e)
        {
            if (listBoxAssignments.SelectedIndex > -1)
            {
                assignments.RemoveAt(listBoxAssignments.SelectedIndex);
            }

            //WriteRecord();
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

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
        static BindingList<Assignment> assignments = new BindingList<Assignment>();
        
        public Form4()
        {
           
            LoadRecord();
            InitializeComponent();
            BindListBox();
        }
        private void BindListBox()
        {
            //dataGridAssignments.DataSource = assignments;
            //dataGridAssignments.ColumnAsg = "displayAssignmentName";
        }
        //add Assignment
        
        private void btnAA_Click(object sender, EventArgs e)
        {

            if (comboBoxCategory.SelectedIndex == 0)
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

            else if (comboBoxCategory.SelectedIndex == 1)
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
            else if (comboBoxCategory.SelectedIndex == 2)
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
            else if (comboBoxCategory.SelectedIndex == 3)
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

            else if (comboBoxCategory.SelectedIndex == 4)
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
            else if (comboBoxCategory.SelectedIndex == 5)
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
            WriteRecord();
        }

        private void btnEA_Click(object sender, EventArgs e)
        {

        }

        private void btnDA_Click(object sender, EventArgs e)
        {



            WriteRecord();
        }

        //serialization part


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

        
    }

}

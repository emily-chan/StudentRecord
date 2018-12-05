using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StudentRecord
{
    public partial class Form1 : Form
    {
        static BindingList<Student> students = new BindingList<Student>();
        //Serialization serialize = new Serialization();
        public Form1()
        {
            // serialize.LoadRecord(students);
            LoadRecord();
            InitializeComponent();
            BindListBox();
        }
        private void BindListBox()
        {
            listBoxStudents.DataSource = students;
            listBoxStudents.DisplayMember = "displayStudent";
        }
        //add student 
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(comboLevel.SelectedIndex == 0)//based on the selected index of the combobox
            {
   
                students.Add(new Student()
                {
                    firstName = textboxFirst.Text,
                    lastName = textboxLast.Text,
                    id = textboxID.Text,
                    level = "Freshman"
                });
                   
            }
            else if (comboLevel.SelectedIndex == 1)
            {

                students.Add(new Student()
                {
                    firstName = textboxFirst.Text,
                    lastName = textboxLast.Text,
                    id = textboxID.Text,
                    level = "Sophomore"
                });

            }
            else if (comboLevel.SelectedIndex == 2)
            {

                students.Add(new Student()
                {
                    firstName = textboxFirst.Text,
                    lastName = textboxLast.Text,
                    id = textboxID.Text,
                    level = "Junior"
                });

            }
            else if (comboLevel.SelectedIndex == 3)
            {

                students.Add(new Student()
                {
                    firstName = textboxFirst.Text,
                    lastName = textboxLast.Text,
                    id = textboxID.Text,
                    level = "Senior"
                });

            }
            WriteRecord();

        }
        //to open form 2
        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listBoxStudents.SelectedIndex > -1)
            {
                //we need to figure out a way to link the student, with the term and class.... link everything together.
                Student student = students[listBoxStudents.SelectedIndex];
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
       
       

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            //don't know what to code to edit.
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            

            if(listBoxStudents.SelectedIndex > -1)
            {
                students.RemoveAt(listBoxStudents.SelectedIndex);
            }

            WriteRecord();
        }


        //serialization part


        public static void WriteRecord()
        {
            //serialization-xml
            XmlSerializer serializerW = new XmlSerializer(typeof(BindingList<Student>));
            TextWriter writer = new StreamWriter("serialized.xml");
            serializerW.Serialize(writer, students);
            writer.Close();
        }
        public static void LoadRecord()
        {
            try
            {
                //deserialization-xml
                XmlSerializer serializerR = new XmlSerializer(typeof(BindingList<Student>));
               TextReader reader = new StreamReader("serialized.xml");
                students = (BindingList<Student>)serializerR.Deserialize(reader);
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error");
            }
        }

       
    }
}

﻿using System;
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
        public static BindingList<Student> students = new BindingList<Student>();
        
        public Form1()
        {
           
            //LoadRecord();
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
            //WriteRecord();

        }
        //to open form 2
        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listBoxStudents.SelectedIndex > -1)
            {
                //we need to figure out a way to link the student, with the term and class.... link everything together.
                
                Form2 f2 = new Form2(this, listBoxStudents.SelectedIndex);
                f2.Show();
            }
        }
       
       
       
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            //don't know what to code to edit.

            if (listBoxStudents.SelectedIndex > -1)
            {
                //it edits but it adds another student.

                textboxFirst.Text = students[listBoxStudents.SelectedIndex].firstName;
                textboxLast.Text = students[listBoxStudents.SelectedIndex].lastName;
                textboxID.Text = students[listBoxStudents.SelectedIndex].id;

                //remove after, so when you click save, it doesnt have two variables.
                //students.RemoveAt(listBoxStudents.SelectedIndex);
                
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            

            if(listBoxStudents.SelectedIndex > -1)
            {
                students.RemoveAt(listBoxStudents.SelectedIndex);
            }

            //WriteRecord();
        }


        //serialization part
        //i don't know to serialize a dictionary

      /* public static void WriteRecord()
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
        }*/

       
    }
}

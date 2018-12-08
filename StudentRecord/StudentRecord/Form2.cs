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
    public partial class Form2 : Form
    {
        static BindingList<Term> springTerm = new BindingList<Term>(); 
        static BindingList<Class> classes = new BindingList<Class>();
        static Form1 obj = new Form1();

        int studentIdx;

        public Form2(Form1 form1, int student)
        {
            LoadRecord();
            InitializeComponent();
            obj = form1;
            studentIdx = student;
           // Form1.students[studentIdx];// this is what you use to reference back to student fromm form one so everything updates.
            
            BindListBox();

        }

        private void BindListBox()
        {
            listboxFall.DataSource = classes;
            listboxFall.DisplayMember = "displayClass";

            listboxSpring.DataSource = classes;
            listboxSpring.DisplayMember = "displayClass";
        }
        
        private void btnAddClass_Click(object sender, EventArgs e)
        {   
            Term t;
            Class c;

            if (tabControlClass.SelectedIndex == 0)
            {
                t = new Term { semester = "Fall", year = textBoxYear.Text };
                c = new Class { className = textboxClass.Text, classNumber = textBoxNumber.Text };
                classes.Add(c);

                if (Form1.students[studentIdx].studentClasses.ContainsKey(t))
                {
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
                else
                {
                    Form1.students[studentIdx].studentClasses.Add(t, new List<Class>());
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }

            }
            else if (tabControlClass.SelectedIndex == 1)
            {
                t = new Term { semester = "Spring", year = textBoxYear.Text };
                c = new Class { className = textboxClass.Text, classNumber = textBoxNumber.Text };
                classes.Add(c);

                if (Form1.students[studentIdx].studentClasses.ContainsKey(t))
                {
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
                else
                {
                    Form1.students[studentIdx].studentClasses.Add(t, new List<Class>());
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
            }
            if (comboTerm.Equals("Fall"))
            {
                if (tabControlClass.SelectedIndex == 0)
                {
                    classes.Add(new Class()
                    {
                        className = textboxClass.Text,
                        classNumber = textBoxNumber.Text
                    });

                }
            }
           WriteRecord();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (tabControlClass.SelectedIndex == 0)
            {
                if(listboxFall.SelectedIndex > -1)
                {
                    classes.RemoveAt(listboxFall.SelectedIndex);
                }
            }
            else if(tabControlClass.SelectedIndex == 1)
            {
                if (listboxFall.SelectedIndex > -1)
                {
                    classes.RemoveAt(listboxSpring.SelectedIndex);
                }
            }
           WriteRecord();
        }


        //serialization part


       public static void WriteRecord()
        {
            //serialization-xml
            XmlSerializer serializerW = new XmlSerializer(typeof(BindingList<Class>));
            TextWriter writer = new StreamWriter("serialized.xml");
            serializerW.Serialize(writer, classes);
            writer.Close();
        }
        public static void LoadRecord()
        {
            try
            {
                //deserialization-xml
                XmlSerializer serializerR = new XmlSerializer(typeof(BindingList<Class>));
                TextReader reader = new StreamReader("serialized.xml");
                classes = (BindingList<Class>)serializerR.Deserialize(reader);
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error");
            }
        }

       
    }
}

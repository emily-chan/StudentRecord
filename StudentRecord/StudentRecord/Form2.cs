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
        //static BindingList<Term> springTerm = new BindingList<Term>(); 
        static BindingList<Class> classes = new BindingList<Class>();
        static BindingList<Term> springTerm = new BindingList<Term>();
        static BindingList<Class> fallClasses = new BindingList<Class>();
        static BindingList<Class> springClasses = new BindingList<Class>();
        //static BindingList<Class> classes = new BindingList<Class>();
        static BindingList<Assignment> categories = new BindingList<Assignment>();

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
            listboxFall.DataSource = fallClasses;
            listboxFall.DisplayMember = "displayClass";

            listboxSpring.DataSource = springClasses;
            listboxSpring.DisplayMember = "displayClass";

            listBoxCategories.DataSource = categories;
            listBoxCategories.DisplayMember = "displayCategory";
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Term t;
            Class c;

            string term = comboTerm.Items[comboTerm.SelectedIndex].ToString();

            if (term.Equals("Fall"))
            {
                t = new Term
                {
                    semester = "Fall",
                    year = textBoxYear.Text
                };
                c = new Class
                {
                    className = textboxClass.Text,
                    classNumber = textBoxNumber.Text
                };
                fallClasses.Add(c);

                if (Form1.students[studentIdx].studentClasses.ContainsKey(t))
                {
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
                else
                {
                    Form1.students[studentIdx].studentClasses.Add(t, new List<Class>());
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
                tabControlClass.SelectedTab = tabFall;
            }
            else if (term.Equals("Spring"))
            {
                t = new Term
                {
                    semester = "Spring",
                    year = textBoxYear.Text
                };
                c = new Class
                {
                    className = textboxClass.Text,
                    classNumber = textBoxNumber.Text
                };
                springClasses.Add(c);

                if (Form1.students[studentIdx].studentClasses.ContainsKey(t))
                {
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
                else
                {
                    Form1.students[studentIdx].studentClasses.Add(t, new List<Class>());
                    Form1.students[studentIdx].studentClasses[t].Add(c);
                }
                tabControlClass.SelectedTab = tabSpring;
            }

            if (fallClasses.Count == 1)
            {
                listboxFall.SelectedIndex = 0;
                listboxFall_SelectedIndexChanged(sender, e);
                listboxFall.Update();
            }
            if (springClasses.Count == 1)
            {
                listboxSpring.SelectedIndex = 0;
                listboxSpring_SelectedIndexChanged(sender, e);
                listboxSpring.Update();
            }
            
            WriteRecord();
        }

        private void listboxFall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxFall.SelectedIndex > -1)
            {
                // updates label to show info of the item that is selected
                lblClassInfo.Text = fallClasses[listboxFall.SelectedIndex].displayClass;
            }
        }

        private void listboxSpring_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxSpring.SelectedIndex > -1)
            {
                lblClassInfo.Text = springClasses[listboxSpring.SelectedIndex].displayClass;
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (tabControlClass.SelectedTab == tabFall && listboxFall.SelectedIndex > -1)
            {
                fallClasses.RemoveAt(listboxFall.SelectedIndex);
            }
            else if (tabControlClass.SelectedTab == tabSpring && listboxSpring.SelectedIndex > -1)
            {
                springClasses.RemoveAt(listboxSpring.SelectedIndex);
            }
            lblClassInfo.Text = "";
            WriteRecord();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Assignment c;
            string category = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();
            if (category.Equals("Homework"))
            {
                c = new Assignment
                {
                    category = "Homework",
                    weight = textBoxWeight.Text,
                };
                categories.Add(c);

            }
            else if (category.Equals("Participation"))
            {
                c = new Assignment
                {
                    category = "Participation",
                    weight = textBoxWeight.Text,
                };
                categories.Add(c);
            }
            else if (category.Equals("Midterm"))
            {
                c = new Assignment
                {
                    category = "Midterm",
                    weight = textBoxWeight.Text,
                };
                categories.Add(c);
            }
            else if (category.Equals("Quizzes"))
            {
                c = new Assignment
                {
                    category = "Quizzes",
                    weight = textBoxWeight.Text,
                };
                categories.Add(c);
            }
            else if (category.Equals("Final"))
            {
                c = new Assignment
                {
                    category = "Final",
                    weight = textBoxWeight.Text,
                };
                categories.Add(c);
            }
            else if (category.Equals("Projects"))
            {
                c = new Assignment
                {
                    category = "Projects",
                    weight = textBoxWeight.Text,
                };
                categories.Add(c);
            }
            WriteRecord();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex > -1)
            {
                categories.RemoveAt(listBoxCategories.SelectedIndex);
            }
        }

        
        //serialization part
        public static void WriteRecord()
        {
            //serialization-xml
            XmlSerializer serFall = new XmlSerializer(typeof(BindingList<Class>));
            TextWriter writeFall = new StreamWriter("fallClasses.xml");
            XmlSerializer serSpring = new XmlSerializer(typeof(BindingList<Class>));
            TextWriter writeSpring = new StreamWriter("springClasses.xml");
            serFall.Serialize(writeFall, fallClasses);
            serSpring.Serialize(writeSpring, springClasses);
            writeFall.Close();
            writeSpring.Close();
        }

        public static void LoadRecord()
        {
            try
            {
                //deserialization-xml
                XmlSerializer serFall = new XmlSerializer(typeof(BindingList<Class>));
                TextReader readFall = new StreamReader("fallClasses.xml");
                XmlSerializer serSpring = new XmlSerializer(typeof(BindingList<Class>));
                TextReader readSpring = new StreamReader("springClasses.xml");
                fallClasses = (BindingList<Class>)serFall.Deserialize(readFall);
                springClasses = (BindingList<Class>)serSpring.Deserialize(readSpring);
                readFall.Close();
                readSpring.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error");
            }
        }

        private void btnGpaCalculator_Click(object sender, EventArgs e)
        {
            GPACalculator f3 = new GPACalculator();
            f3.Show();
        }

        private void btnFinalGradeCalc_Click(object sender, EventArgs e)
        {
            FinalGradeCalc f5 = new FinalGradeCalc();
            f5.Show();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}


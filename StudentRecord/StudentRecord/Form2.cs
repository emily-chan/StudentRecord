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
        static BindingList<Term> terms = new BindingList<Term>();
        static BindingList<Class> classes = new BindingList<Class>();
        public Form2()
        {
            LoadRecord();
            InitializeComponent();
            BindListBox();
        }

        private void BindListBox()
        {
            listboxFall.DataSource = classes;
            listboxFall.DisplayMember = "displayClass";

            listboxSpring.DataSource = classes;
            listboxSpring.DisplayMember = "displayeClass";
        }
        
        private void btnAddClass_Click(object sender, EventArgs e)
        {
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
            XmlSerializer serializerW = new XmlSerializer(typeof(BindingList<Student>));
            TextWriter writer = new StreamWriter("serialized.xml");
            serializerW.Serialize(writer, classes);
            writer.Close();
        }
        public static void LoadRecord()
        {
            try
            {
                //deserialization-xml
                XmlSerializer serializerR = new XmlSerializer(typeof(BindingList<Student>));
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

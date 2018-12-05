using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentRecord
{
    class Serialization
    {
        public XmlSerializer serializerW;
        public TextWriter writer;
        public XmlSerializer serializerR;
        public TextReader reader;

        public void WriteRecord(BindingList<String>list)
        {
            //serialization-xml
            serializerW = new XmlSerializer(typeof(BindingList<String>));
            writer = new StreamWriter("serialized.xml");
            serializerW.Serialize(writer, list );
            writer.Close();
        }
        public void LoadRecord(BindingList<String> list)
        {
            try
            {
                //deserialization-xml
                serializerR = new XmlSerializer(typeof(BindingList<String>));
                reader = new StreamReader("serialized.xml");
                list = (BindingList<String>)serializerR.Deserialize(reader);
                reader.Close();
            }catch (FileNotFoundException e)
            {
                Console.WriteLine("Error");
            }
        }
    }
}

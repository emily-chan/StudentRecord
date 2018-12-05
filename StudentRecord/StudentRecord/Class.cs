using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    public class Class:Term
    {
        public string className;
        public string classNumber;
        

        public Class()
        {
            className = "";
            classNumber = "";
        }

        public string displayClass { get { return semester+" "+ year + " - " + className + "(" + classNumber+ ")"; } }
    }
}

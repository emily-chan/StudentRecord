using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    [Serializable]
    class Student
    {
        private string firstName;
        private string lastName;
        private int id;
       // private string level;

        public Student()
        {
            firstName = "";
            lastName = "";
            id = 0;
            
        } 

    }
}

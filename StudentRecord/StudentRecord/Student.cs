using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    [Serializable]
    public class Student
    {
        public string firstName;
        public string lastName;
        public string id;
        public string level;

        public Student()
        {
            firstName = "";
            lastName = "";
            id = "";
            
        } 
        public string displayStudent { get { return firstName + ", " + lastName + " | " + id + " | " + level; } }

    }
}

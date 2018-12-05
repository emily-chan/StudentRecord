﻿using System;
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
        //terms and semesters that they had.
        //disctionary, a term as its key, and as its value a dictionary the key the 
        public Dictionary<Term, List<Class>> studentClasses = new Dictionary<Term, List<Class>>();

        public Student()
        {
            firstName = "";
            lastName = "";
            id = "";
            //studentClasses = new Dictionary<Term, List<Class>>();

        }
        public string displayStudent { get { return firstName + ", " + lastName + " | " + id + " | " + level; } }

    }
}

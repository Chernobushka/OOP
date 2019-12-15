using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Student
    {
        public string name;
        public string course;

        public Student()
        { }

        public Student(string _name, string _course)
        {
            name = _name;
            course = _course;
        }

        public override string ToString()
        {
            return this.name + " " + this.course + " course";
        }
    }
}

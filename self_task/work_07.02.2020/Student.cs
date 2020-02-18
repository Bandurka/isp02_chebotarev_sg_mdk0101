using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        private string name { get; set; }
        private int course { get; set; }
        private readonly string gender;

        public Student(string studentName, int studentCourse, string studentGender)
        {
            name = studentName;
            course = studentCourse;
            gender = studentGender;
        }

        public override string ToString()
        {
            return "Student: " + name + " " + course + " " + gender;
        }
    }
}

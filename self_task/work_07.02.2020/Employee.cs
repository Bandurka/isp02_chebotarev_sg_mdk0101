using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        private string name { get; set; }
        private string profession { get; set; }
        private int workExperience { get; set; }

        public Employee(string employeeName, string employeeProfession, int employeeWorkExperience)
        {
            name = employeeName;
            profession = employeeProfession;
            workExperience = employeeWorkExperience;
        }

        public override string ToString()
        {
            return "Employee: " + name + " " + profession + " " + workExperience;
        }
    }
}

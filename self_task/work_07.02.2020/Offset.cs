using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Offset
    {
        private string fullNameStudent { get; set; }
        private string fullNameTeacher { get; set; }
        public double date { get; set; }
        public int assessment { get; set; }

        public Offset(string offsetFullnameStudent, string offsetFullnameTeacher,
                        double offsetDate, int offsetAssessment)
        {
            fullNameStudent = offsetFullnameStudent;
            fullNameTeacher = offsetFullnameTeacher;
            date = offsetDate;
            assessment = offsetAssessment;
        }

        public override string ToString()
        {
            return "Offset: " + fullNameStudent + " " + fullNameTeacher + " " + date + " " + assessment;
        }
    }
}

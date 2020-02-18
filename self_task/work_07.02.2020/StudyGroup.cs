using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class StudyGroup
    {
        private string cipher { get; set; }
        private int numberOfStudents { get; set; }
        private int yearOfFormation { get; set; }
        private string speciality { get; set; }

        public StudyGroup(string studyGroupCipher, int studyGroupNumberOfStudends,
                            int studyGroupYearOfFormation, string studyGroupSpeciality)
        {
            cipher = studyGroupCipher;
            numberOfStudents = studyGroupNumberOfStudends;
            yearOfFormation = studyGroupYearOfFormation;
            speciality = studyGroupSpeciality;
        }

        public override string ToString()
        {
            return "StudyGroup: " + cipher + " " + numberOfStudents + " " + yearOfFormation + " " + speciality;
        }
    }
}

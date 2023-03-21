using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentData
    {
        private static List<Student> testStudents = new List<Student>();
        public static void ResetTestStudentData()
        {
            testStudents.Add(new Student("Tsvetelina", "Tsvetanova", "Stefanova", "FKST", "KSI", 
                "Bachelor", "NotGraduated", 121220181, 3, 10, 43));
        }
        public static List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return testStudents;
            }
            set { testStudents = value; }
        }
    }
}

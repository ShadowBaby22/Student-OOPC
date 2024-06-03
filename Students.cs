using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_OOPC
{
    public class Student
    {
        public int rollNo { get; set; }
        public string name { get; set; }
        public List<Student> subjects { get; set; }

        public Student(int rollNumber, string Name, List<Student> Subjects) 
        {
            rollNo = rollNumber;
            name = Name;
            subjects = Subjects;
        }
    }
}

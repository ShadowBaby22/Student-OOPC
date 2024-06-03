using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_OOPC
{
    public class Subject : Student
    {
        public int subjectId;
        public string subjectName;
        public int subjectMarks;
        public Subject(int rollNumber, string Name, List<Student> Subjects): base(rollNumber, Name, Subjects)
        { 
            subjectName = string.Empty;
            if (subjectMarks >100 || subjectMarks < 0)
            {
                throw new Exception("Invalid Input"); 
            }
        }

        /*public AddSubject()
        {
            Subject subject = new();
            return 
        }*/


    }
}

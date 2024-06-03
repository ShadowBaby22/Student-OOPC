using Student_OOPC;
using System;
using System.Collections.Generic;

/*Student Class
→ roll no, name, Subjects(list) 
Subject Class
→ Subject Name, ID, Marks 
From console: Add a student and a 
Press 1 to Add student
Enter roll no
Enter name
How many subjects do you want to add 
–(less than 6 condition) 
Enter Subject Id
Enter Subject Name
Marks obtained in Subject { Id} { Name} : 


Use your own knowledge to enhance and add features: */

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Students Name");
            Student student = new Student();
            student.name = Console.ReadLine();

            Console.WriteLine("Enter their roll no");
            student.rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("How many subjects are they taking this year?");
            int subjectCount = int.Parse(Console.ReadLine());

            if (subjectCount < 0 || subjectCount >6 ) 
            {
                Console.WriteLine("Invalid Input, Please senter your choice again");
                subjectCount= 0;
                subjectCount = int.Parse(Console.ReadLine()) ;
            }

            for (int i = 0; i < subjectCount ; i++)
            {
                Subject subject = new Subject();
                Console.WriteLine("Enter Subject Id");
                
                subject.subjectId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Subject Name");
                subject.subjectName = Console.ReadLine();

                Console.WriteLine($"How much did {student.name} score in {subject.subjectName}"); 
                subject.subjectMarks = int.Parse(Console.ReadLine());

                student.subjects.Add(subject);

                Console.WriteLine("Subjects in list Subject");
                Console.WriteLine(string.Join("\n", student.subjects));

                /*//Display Student with List 
                for (int l = 0; l < student.subjects.Count; l++)
                {
                    Console.WriteLine($"{student.name} obtained {subject.subjectMarks} in {subject.subjectName}");
                }*/
            }
        }
    }
}
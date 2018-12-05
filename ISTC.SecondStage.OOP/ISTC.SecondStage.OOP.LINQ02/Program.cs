using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.LINQ02
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[5] {
                new Student { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
                new Student { StudentId = 4, StudentName = "Ram" , Age = 20  } ,
                new Student { StudentId = 5, StudentName = "Ron" , Age = 21 }
            };

            var studentNames = from s in studentList
                               select new
                               {
                                   StudentID = s.StudentId,
                                   StudentName = s.StudentName
                               };

            for (int i = 0; i < studentList.Length; i++)
            {
                Console.Write(studentList[i].StudentId + ".");
                Console.WriteLine(studentList[i].StudentName);
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}

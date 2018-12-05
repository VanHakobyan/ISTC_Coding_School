using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.LINQ03
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardId { get; set; }
    }
    class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[] {
                new Student { StudentId = 1, StudentName = "John", Age = 18,  StandardId= 1 } ,
                new Student { StudentId = 2, StudentName = "Steve",  Age = 21, StandardId = 1 } ,
                new Student { StudentId = 3, StudentName = "Bill",  Age = 18, StandardId = 2 } ,
                new Student { StudentId = 4, StudentName = "Ram" , Age = 20, StandardId = 2 } ,
                new Student { StudentId = 5, StudentName = "Ron" , Age = 21 }
            };

            Standard[] standardList = new Standard[] {
                new Standard { StandardId = 1, StandardName = "Standard 1" },
                new Standard { StandardId = 2, StandardName = "Standard 2" },
                new Standard { StandardId = 3, StandardName = "Standard 3" }};




            //Multiple Select and where Operator
            var studentNames = studentList.Where(s => s.Age > 18)
                .Select(s => s)
                .Where(st => st.StandardId > 0)
                .Select(s => s.StudentName);


            //LINQ Query returns Collection of Anonymous Objects
            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));


            //LINQ GroupBy Query - C#
            var studentsGroupByStandard = from s in studentList
                                          group s by s.StandardId into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };


            foreach (var group in studentsGroupByStandard)
            {
                Console.WriteLine("StandardId {0}:", group.Key);

                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }


            //LINQ GroupBy Query - C#
            var studentsGroupByStandard2 = from s in studentList
                                          where s.StandardId > 0
                                          group s by s.StandardId into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };

            foreach (var group in studentsGroupByStandard2)
            {
                Console.WriteLine("StandardID {0}:", group.Key);

                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }



            //LINQ Left Outer Join - C#
            var studentsGroup = from stad in standardList
                join s in studentList
                    on stad.StandardId equals s.StandardId
                    into sg
                select new
                {
                    StandardName = stad.StandardName,
                    Students = sg
                };

            foreach (var group in studentsGroup)
            {
                Console.WriteLine(group.StandardName);

                group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }




            //LINQ Left Outer Join - C#
            var studentsWithStandard = from stad in standardList
                join s in studentList
                    on stad.StandardId equals s.StandardId
                    into sg
                from std_grp in sg
                orderby stad.StandardName, std_grp.StudentName
                select new
                {
                    StudentName = std_grp.StudentName,
                    StandardName = stad.StandardName
                };


            foreach (var group in studentsWithStandard)
            {
                Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
            }


            //Sorting
            var sortedStudents = from s in studentList
                orderby s.StandardId, s.Age
                select new
                {
                    StudentName = s.StudentName,
                    Age = s.Age,
                    StandardID = s.StandardId
                };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: {1}, StandardID: {2}", s.StudentName, s.Age, s.StandardID));




            //LINQ Inner join - C#
            var studentWithStandard = from s in studentList
                join stad in standardList
                    on s.StandardId equals stad.StandardId
                select new
                {
                    StudentName = s.StudentName,
                    StandardName = stad.StandardName
                };

            studentWithStandard.ToList().ForEach(s => Console.WriteLine("{0} is in {1}", s.StudentName, s.StandardName));


            //Nested Query
            var nestedQueries = from s in studentList
                where s.Age > 18 && s.StandardId ==
                      (from std in standardList
                          where std.StandardName == "Standard 1"
                          select std.StandardId).FirstOrDefault()
                select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));
        }
    }

}

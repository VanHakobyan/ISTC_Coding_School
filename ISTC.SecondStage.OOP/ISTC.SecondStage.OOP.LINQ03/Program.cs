﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingGeneric;

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
                new Student { StudentId = 1, StudentName = "Steve",  Age = 21, StandardId = 1 } ,
                new Student { StudentId = 0, StudentName = "Bill",  Age = 18, StandardId = 2 } ,
                new Student { StudentId = 54, StudentName = "Ram" , Age = 20, StandardId = 2 } ,
                new Student { StudentId = 5, StudentName = "Ron" , Age = 21 }
            };

            Standard[] standardList = new Standard[] {
                new Standard { StandardId = 1, StandardName = "Standard 1" },
                new Standard { StandardId = 2, StandardName = "Standard 2" },
                new Standard { StandardId = 3, StandardName = "Standard 3" }
            };


            //Multiple Select and where Operator
            var studentNames = studentList
                .Where(s => s.Age > 18 && s.StandardId > 0)
                .Select(s => s.StudentName).ToArray();


            //LINQ Query returns Collection of Anonymous Objects
            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };


            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));


            //LINQ GroupBy Query - C#
            //var studentsGroupByStandard = from s in studentList
            //                              group s by s.StandardId into sg
            //                              orderby sg.Key
            //                              select new { sg.Key, sg };

            var studentsGroupByStandard = studentList
                .GroupBy(s => s.StandardId)
                .OrderBy(sg => sg.Key)
                .Select(sg => new { Key = sg.Key, Count = sg.Count() });

            foreach (var group in studentsGroupByStandard)
            {
                Console.WriteLine("StandardId {0}:", group.Key);

                //group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
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
            //var studentsGroup = standardList.GroupJoin(studentList, 
            //    stad => stad.StandardId, 
            //    s => s.StandardId,
            //    (stad, sg) => new { StandardName = stad.StandardName, Students = sg });
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
                                 orderby  s.StandardId, s.Age descending 
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
            var nestedQueries = studentList
                .Where(
                 s => s.Age > 18 && s.StandardId == (
                          standardList.Where(std => std.StandardName == "Standard 1")
                .Select(std => std.StandardId)).FirstOrDefault()
                      );

            foreach (var s in nestedQueries) Console.WriteLine(s.StudentName);
            var studentIds = studentList.Select(x => x.StudentId);
            var standardIds = standardList.Select(x => x.StandardId);
            var allIds = standardIds.Concat(studentIds);
            var skipWhile = allIds.SkipWhile(i => i != 54);
            Console.WriteLine(allIds.Count());
        }
    }

    internal class MyClass
    {
        public int Key { get; set; }
        public int Count { get; set; }

    }
}

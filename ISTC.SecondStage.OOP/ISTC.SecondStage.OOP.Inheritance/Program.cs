using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTC.SecondStage.OOP.Inheritance.Example;

namespace Inheritance
{
    public class Actor
    {
        public int SingleCount = 52;
    }
    public class Human//base
    {
        protected string gender;

        public Human(string firstName)
        {
            FirstName = firstName;
        }
        public Human(int age)
        {
            Age = age;
        }
        public Human() { }

        public string FirstName { get; set; }
        protected string LastName { get; set; }
        public int Age { get; set; }
        public void Say()
        {
            Console.WriteLine("I am a human !!!");
        }
    }

    //der
    public class Student : Human
    {
        public Student(int gpa, int age) : base(age)
        {
            GPA = gpa;
        }
        public float GPA { get; set; }
        public int Course { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public int Price { get; set; }
        public bool IsPaid { get; set; } = true;

        public void Learn()
        {
            Console.WriteLine("I can learn !!!");
        }

        private void SetGender()
        {
            gender = "Male";
        }
    }

    public class RomanoStudent : Student
    {
        public bool IsBeauty { get; set; } = true;
        public void Talk()
        {
            Console.WriteLine("I am GAZAN developer !!!");
        }
        public RomanoStudent(int gpa, int age) : base(gpa, age)
        {
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetGender()
        {
            return gender;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(10, 15);
            var area = rectangle.GetArea();

            Square square = new Square(96);
            var littleR = square.GetLittleR();

            Human human = new Human();
            human.Say();

            Student student = new Student(18, 21);
            student.Say();
            student.Learn();

            RomanoStudent romanoStudent = new RomanoStudent(5, 19);
            romanoStudent.Say();
            romanoStudent.Learn();
            romanoStudent.Talk();
            romanoStudent.GetGender();

            Console.WriteLine(student.Age);
            Console.ReadKey();
        }
    }
}

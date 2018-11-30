using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            const string lastName = "Smith";
            const byte age = 52;
            const string gender = "male";

            //bad practice 
            string badText = firstName + '\n' + lastName + "\t" + age + " " + gender;

            //good practice
            string goodText = $"firstName : {firstName} \nlastName : {lastName} \nage : {age} \ngender : {gender}";
            firstName = "Alex";

            Console.WriteLine(goodText);
            Console.WriteLine(firstName);

            //var x = 5;
            //x = "hello"; //error

            //dynamic a = 45;
            //a = "asc";

            int b = 4;
            if (b<=15)
            {

            }
        }

    }
}

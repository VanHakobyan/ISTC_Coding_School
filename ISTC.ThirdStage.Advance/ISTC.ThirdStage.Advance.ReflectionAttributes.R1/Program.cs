using System;
using System.Reflection;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.R1
{
    static class ReflectionTest
    {
        public static int Height;
        public static int Width;
        public static int Weight;
        public static string Name;

        public static void Write()
        {
            Type type = typeof(ReflectionTest);    // Get type pointer
            FieldInfo[] fields = type.GetFields(); // Obtain all fields
            foreach (var field in fields)          // Loop through fields
            {
                string name = field.Name;               // Get string name
                object fieldValue = field.GetValue(null); // Get value
                if (fieldValue is int)                        // See if it is an integer.
                {
                    int value = (int)fieldValue;
                    Console.Write(name);
                    Console.Write(" (int) = ");
                    Console.WriteLine(value);
                }
                else if (fieldValue is string)                // See if it is a string.
                {
                    string value = fieldValue as string;
                    Console.Write(name);
                    Console.Write(" (string) = ");
                    Console.WriteLine(value);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ReflectionTest.Height = 100;    // Set value
            ReflectionTest.Width = 50;      // Set value
            ReflectionTest.Weight = 300;    // Set value
            ReflectionTest.Name = "Perl";   // Set value
            ReflectionTest.Write();         // Invoke reflection methods
        }
    }
}

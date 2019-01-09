using System;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.A2
{
    [Developer("Joan Smith", "42", Reviewed = true)]
    class Program
    {
        static void Main(string[] args)
        {
            // Call function to get and display the attribute.
            GetAttribute(typeof(Program));
        }
        public static void GetAttribute(Type t)
        {
            // Get instance of the attribute.
            DeveloperAttribute MyAttribute = (DeveloperAttribute)Attribute.GetCustomAttribute(t, typeof(DeveloperAttribute));

            if (MyAttribute == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                // Get the Name value.
                Console.WriteLine("The Name Attribute is: {0}.", MyAttribute.Name);
                // Get the Level value.
                Console.WriteLine("The Level Attribute is: {0}.", MyAttribute.Level);
                // Get the Reviewed value.
                Console.WriteLine("The Reviewed Attribute is: {0}.", MyAttribute.Reviewed);
            }
        }
    }
}

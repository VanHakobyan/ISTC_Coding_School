using System;
using Newtonsoft.Json;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Նառա", LastName = "Նառա դու սուո", Age = 45, PhoneNumber = 101020,Email = "kjhgcvbkhj"};
            string serializeObject = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine(serializeObject);
            Console.ReadKey();
        }
    }
}

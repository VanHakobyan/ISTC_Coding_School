using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal 
    {

        public virtual void Voice()
        {
            Console.WriteLine("_");
        }
    }

    class Cat : Animal
    {
        public int x;
        public override void Voice()
        {
            Console.WriteLine("Mrrr !!!");
        }
    }

    class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Haf !!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // is
            // as

            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            //Console.WriteLine("Enter the magnet that You Need");
            string animalType = "";//Console.ReadLine();
            if (animal1 == animal2)
            {
            }
            animal2 = animal1;
            Console.WriteLine(animal2.GetHashCode());
            Console.WriteLine(animal1.GetHashCode());
            Cat cat = null;
            cat = new Cat();
            object my = cat as Object; //UpCast

            switch (animalType)
            {
                case "cat":

                    if (cat is Animal)
                    {

                    }

                    break;

                case "dog":
                    animal1 = new Dog();
                    break;

                default:
                {
                    Console.WriteLine("Error: Wrong magnet name");
                    break;
                }
            }

            if (animal1 != null)
            {
                animal1.Voice();
            }
            cat = (Cat)animal1;//DownCast
            int x = cat.x;
            Console.ReadKey();


        }
    }
}

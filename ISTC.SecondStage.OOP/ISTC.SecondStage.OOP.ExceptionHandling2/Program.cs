using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.ExceptionHandling2
{

    //* try − A try block identifies a block of code for which particular exceptions is activated.
    //It is followed by one or more catch blocks.

    //* catch − A program catches an exception with an exception handler at the place in a 
    //program where you want to handle the problem.
    //The catch keyword indicates the catching of an exception.

    //* finally − The finally block is used to execute a given set of statements, 
    //whether an exception is thrown or not thrown.For example,
    //if you open a file, it must be closed whether an exception is raised or not.

    //* throw − A program throws an exception when a problem shows up. This is done using a throw keyword.

    class Program
    {
        static void M1()
        {
            try
            {
                M2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void M2()
        {
            try
            {
                M3();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static void M3()
        {
            try
            {
                var res = 10 / int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        static void Main(string[] args)
        {
            M1();
            string[] array = new string[4];// 0 1 2 3 indexs
            try
            {
                array[1] = "array[1]";
                array[int.Parse(Console.ReadLine())] = "array[4]"; //exception

                array[3] = "array[3]";
                var item = 1 / int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

        }
    }
}

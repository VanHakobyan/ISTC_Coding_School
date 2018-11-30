using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.ExceptionHandling2
{

    //* try − A try block identifies a block of code for which particular exceptions is activated.
    //It is followed by one or more catch blocks.

    //* catch − A program catches an exception with an exception handler at the place in a program where you want to handle the problem.
    //The catch keyword indicates the catching of an exception.

    //* finally − The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown.For example,
    //if you open a file, it must be closed whether an exception is raised or not.

    //* throw − A program throws an exception when a problem shows up. This is done using a throw keyword.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[]  array=new string[4];

                array[1] = "array[1]";
                array[4] = "array[4]";//exception
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Close");
            }
        }
    }
}

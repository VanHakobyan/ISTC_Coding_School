using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.ExceptionHandling3
{

    class Program
    {
        public static string Method(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                return s.Replace("k", "m");
            }
            else
            {
                throw new NullReferenceException("s is null");
            }
        }
        static void Main(string[] args)
        {
            int x;
            try
            {
                x = 5;
                Method(null);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) when (e is AggregateException || e is ContextMarshalException) //C# 7 +
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                x = -1;
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadKey();
            
        }
    }
}

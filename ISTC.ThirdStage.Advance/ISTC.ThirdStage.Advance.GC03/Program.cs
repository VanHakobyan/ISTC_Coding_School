﻿using System;

namespace ISTC.ThirdStage.Advance.GC.GC03
{
    class Program
    {
        #region NOTE

        //Because most objects die young, generations are used to optimize which elements are scanned.
        //Newer objects are scanned more often because they are most likely to have become dead.

        #endregion
        static void Main(string[] args)
        { 
            // This loop does a lot of allocations!
            for (int i = 0; i < 100; i++)
            {
                for (int a = 0; a < 1000; a++)
                {
                    System.IO.Path.GetRandomFileName();
                    System.IO.Path.GetRandomFileName();
                }
                System.Threading.Thread.Sleep(1);
            }

            // Display collection counts.
            for (int i = 0; i <= System.GC.MaxGeneration; i++)
            {
                //GC.CollectionCount returns an int. It tells us how many times garbage collection has occurred.
                int count = System.GC.CollectionCount(i);

                Console.WriteLine(count);
            }


            Console.ReadKey();
        }
    }
}

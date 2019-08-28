﻿using System;

namespace ISTC.SecondStage.OOP.Delegate02
{
    class Program
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            Print printDel =  new Print(PrintNumber);
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(1000);

            printDel -= PrintHexadecimal;
            printDel(2000);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}

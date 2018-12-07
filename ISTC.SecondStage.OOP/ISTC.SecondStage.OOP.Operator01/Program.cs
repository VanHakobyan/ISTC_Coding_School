﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Operator01
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point operator +(Point leftPoint, Point rhs)
        {
            return new Point
            {
                X = leftPoint.X + rhs.X,
                Y = leftPoint.Y + rhs.Y
            };
        }

        public static Point operator +(Point leftPoint, double rhs)
            => new Point
            {
                X = leftPoint.X + rhs,
                Y = leftPoint.Y + rhs
            };

        public static bool operator ==(Point lhs, Point rhs) 
            => lhs.X == rhs.X && lhs.Y == rhs.Y;
        
        public static bool operator !=(Point lhs, Point rhs) 
            => !(lhs == rhs);

        // learn and use implicit and explicit operators
    }

    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point { X = 1, Y = 4 };
            var point2 = new Point { X = 2, Y = 3 };

            var point = point1 + 5;

            var point3 = new Point
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y
            };

            var point4 = point1 + point2;

            if (point3 != point4)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
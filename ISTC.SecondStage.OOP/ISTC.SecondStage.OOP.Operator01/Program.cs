using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Operator01
{
    public struct Point
    {

        public override bool Equals(object obj)
        {
            return obj is Point other && (Point)obj == other;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }

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
        {
            return new Point
            {
                X = leftPoint.X + rhs,
                Y = leftPoint.Y + rhs
            };
        }

        public static bool operator ==(Point lhs, Point rhs)
        {
            return IsEqual(lhs.X, rhs.X) && IsEqual(lhs.Y, rhs.Y);
        }
        public bool Equals(Point other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public static bool operator !=(Point lhs, Point rhs)
        {
            return !(lhs == rhs);
        }

        // learn and use implicit and explicit operators
        public static bool IsEqual(double d1, double d2)
        {
            return Math.Abs(d1 - d2) > 0.0001;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            for (float i = 0; Math.Abs(i - (-2f)) > 0.0001f; i -= 0.1f)
            {
                Console.WriteLine(i);
            }



            var point1 = new Point { X = 1, Y = 4 };
            var point2 = new Point { X = 2, Y = 3 };

            var point = point1 + 5;

            var point3 = new Point
            {
                X = point1.X + point2.X,
                Y = point1.Y + point2.Y
            };

            var point4 = point1 + point2;

            //if (point3 != point4)
            if (!point3.Equals(point4))
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

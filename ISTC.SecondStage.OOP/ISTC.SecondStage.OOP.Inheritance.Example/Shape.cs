using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Inheritance.Example
{
    public class Shape
    {
        private static int m;
        private int sideCount;
        static Shape()
        {
            m = 5;
        }

        public Shape(int sideCount)
        {
            this.sideCount = sideCount;
        }
    }

    public class Rectangle : Shape
    {
        static Rectangle()
        {

        }

        private int l;
        private int h;

        public Rectangle(int l, int h) : base(4)
        {
            this.h = h;
            this.l = l;
        }

        public int GetP()
        {
            return 2 * (l + h);
        }

        public int GetArea()
        {
            return l * h;
        }

        public int GetHalfP()
        {
            return GetP() / 2;
        }

        public double GetBigR()
        {
            return Math.Sqrt((l * l + h * h)) / 2;
        }
    }

    public class Square:Rectangle
    {
        //private Square(int sideCount, int l, int h) : base(sideCount, l, h)
        //{
        //}
        private int x;
        public Square(int x) : base(x, x)
        {
            this.x = x;
        }

        public double GetLittleR()
        {
            return x / 2.0;
        }
    }
}

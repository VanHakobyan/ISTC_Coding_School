using System;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.DLL
{
    public class Calculator
    {
        public Calculator() { }
        private double _number;
        public double Number { get; set; }
        public void Clear() { _number = 0; }
        private void DoClear() { Number = 0; }
        public double Add(double number) { _number = number; return number; }
        public static double Pi => Math.PI;
        public static double GetPi() {return Pi;}
    }
}


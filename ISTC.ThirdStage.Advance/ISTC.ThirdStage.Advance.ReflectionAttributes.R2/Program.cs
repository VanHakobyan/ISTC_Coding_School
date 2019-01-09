using System;
using System.Reflection;

namespace ISTC.ThirdStage.Advance.ReflectionAttributes.R2
{
    class Program
    {
        const string path = @"C:\Users\van19\Source\Repos\VanHakobyan\ISTC_Coding_School\ISTC.ThirdStage.Advance\ISTC.ThirdStage.Advance.ReflectionAttributes.DLL\bin\Debug\ISTC.ThirdStage.Advance.ReflectionAttributes.DLL.dll";
        static void Main(string[] args)
        {
            // Using GetType to obtain type information:
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);

            // create instance of struct DateTime
            DateTime dateTime = (DateTime)Activator.CreateInstance(typeof(DateTime));

            // dynamically load assembly from file Test.dll
            Assembly testAssembly = Assembly.LoadFile(path);

            // get type of class Calculator from just loaded assembly
            Type calcType = testAssembly.GetType("ISTC.ThirdStage.Advance.ReflectionAttributes.DLL.Calculator");

            // create instance of class Calculator
            object calcInstance = Activator.CreateInstance(calcType);

            // get info about property: public double Number
            PropertyInfo numberPropertyInfo = calcType.GetProperty("Number");

            // get value of property: public double Number
            double value = (double)numberPropertyInfo.GetValue(calcInstance, null);

            // set value of property: public double Number
            numberPropertyInfo.SetValue(calcInstance, 10.0, null);

            //value after set
            double value2 = (double)numberPropertyInfo.GetValue(calcInstance, null);
        }
    }
}

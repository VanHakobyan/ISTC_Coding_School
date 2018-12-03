using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Generics01
{

    #region MyGenericClassComp


    class MyGenericClass
    {
        private int genericMemberVariable;

        public MyGenericClass(int value)
        {
            genericMemberVariable = value;
        }

        public int GenericMethod(int genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(int).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(int).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public int GenericProperty { get; set; }
    }


    #endregion

    class MyGenericClass<T>
    {
        private T genericMemberVariable;
        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericMethod<L>(T genericParameter, L anotherType) where L : struct // constraint
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T GenericProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<double> intGenericClass = new MyGenericClass<double>(10);

            double val = intGenericClass.GenericMethod(genericParameter: 1500.2, anotherType: 5);

            MyGenericClass<string> intGenericClass2 = new MyGenericClass<string>("d");

            string val2 = intGenericClass2.GenericMethod<int>(genericParameter: "a", anotherType: 5);
        }
    }
}

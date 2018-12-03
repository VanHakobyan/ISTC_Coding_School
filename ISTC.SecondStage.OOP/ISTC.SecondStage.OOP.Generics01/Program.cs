using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.SecondStage.OOP.Generics01
{
    #region MyGenericClassComp


    //class MyGenericClass
    //{
    //    private int genericMemberVariable;

    //    public MyGenericClass(int value)
    //    {
    //        genericMemberVariable = value;
    //    }

    //    public int GenericMethod(int genericParameter)
    //    {
    //        Console.WriteLine("Parameter type: {0}, value: {1}", typeof(int).ToString(), genericParameter);
    //        Console.WriteLine("Return type: {0}, value: {1}", typeof(int).ToString(), genericMemberVariable);

    //        return genericMemberVariable;
    //    }

    //    public int GenericProperty { get; set; }
    //}


    #endregion
    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericMethod<U>(T genericParameter,U anotherType) where U:struct
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
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);

            int val = intGenericClass.GenericMethod<int>(1500,5);
        }
    }
}

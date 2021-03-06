﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.Events
{
    public delegate void DelegateForEvent();  //Created delegate 

    /// <summary>
    /// Event class
    /// </summary>
    public class ClassForEvent
    {
        public event DelegateForEvent MyEvent; //My event 

        public void EventInvoker()
        {
            if (MyEvent != null) MyEvent.Invoke(); //Invoking my event  
        }
    }


    /// <summary>
    /// Secure variant
    /// </summary>
    public class ClassForEventOther
    {
        public bool flag
        {
            get;
            set;
        }
        private DelegateForEvent _delegateForEvent;

        public event DelegateForEvent MyEventSecure
        {
            add { if (_delegateForEvent != null) _delegateForEvent += value; }
            remove { if (flag && _delegateForEvent != null) _delegateForEvent -= value; }
        }

        public void EventInvoker()
        {
            _delegateForEvent.Invoke();
        }
    }

    class Program
    {

        #region Handler

        public static void FirstHandler()
        {
            Console.WriteLine("First Handler");
        }
        public static void SecondHandler()
        {
            Console.WriteLine("Second Handler");
        }
        public static void ThirdHandler()
        {
            Console.WriteLine("Third Handler");
        }

        #endregion

        static void Main(string[] args)
        {
            ClassForEvent classForEvent = new ClassForEvent();

            classForEvent.MyEvent += delegate { FirstHandler(); };          //1 2002
            classForEvent.MyEvent += new DelegateForEvent(SecondHandler);   //2 2007
            classForEvent.MyEvent += ThirdHandler;                          //3 2010

            classForEvent.EventInvoker(); // 1 2 3 

            classForEvent.MyEvent -= SecondHandler;
            classForEvent.EventInvoker(); // 1 3

        }
    }
}

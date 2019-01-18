using System;
using System.Security.Permissions;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Collections;

namespace ISTC.ThirdStage.Advance.Algorithms.Stack
{
    public class StackCustom<T>
    {
        private T[] s;
        private int currentStackIndex;

        public StackCustom(int N)
        {
            if (N < 0)
                throw new ArgumentOutOfRangeException(N.ToString());

            s = new T[N];
            currentStackIndex = 0;
        }

        public void Push(T x)
        {
            if (currentStackIndex + 1 >= s.Length)
            {
                Array.Resize(ref s, (s.Length + 1) * 2);
            }

            s[currentStackIndex] = x;
            currentStackIndex++;
        }

        public T Pop()
        {
            if (currentStackIndex == 0)
                throw new InvalidOperationException("The stack is empty");

            T value = s[--currentStackIndex];
            s[currentStackIndex] = default(T);
            return value;
        }
    }
}

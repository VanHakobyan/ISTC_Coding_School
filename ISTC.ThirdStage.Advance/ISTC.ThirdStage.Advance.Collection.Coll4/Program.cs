using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection.Coll4
{
    class CustomCollection : IEnumerator, IList
    {
        private Custom _head = null;
        private Custom _tail = null;

        private Custom[] _customArr = null;
        private int _position;
        public int Count { get; private set; }
        private int _size;

        public CustomCollection()
        {
            _position = -1;
            Count = 0;
            _size = 25;
            _customArr = new Custom[_size];
        }

        #region IEnumera(ble/tor)

        public object Current => _customArr[_position];

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            if (_position < Count - 1)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

        #endregion

        #region IList (prop)
        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public object SyncRoot => this;

        public bool IsSynchronized => false;
        #endregion

        #region IList (methods)

        public object this[int index]
        {
            get
            {
                try
                {
                    return _customArr[index] as Custom;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

            set
            {

                try
                {
                    if (index >= Count || index < 0)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    _customArr[index] = (Custom)value;

                    _customArr[index].Next = _customArr[index + 1];

                    if (index != 0)
                    {
                        _customArr[index - 1].Next = _customArr[index];
                    }
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public int Add(object value)
        {
            Custom _custom = new Custom(value);

            if (Count == _size)
            {
                _customArr = NewArrayWithCopy(_customArr);
            }

            if (_head == null)
            {
                _head = _custom;
                _tail = _custom;
            }
            else
            {
                _tail.Next = _custom;
                _tail = _custom;
            }

            _customArr[Count++] = _custom;

            return Count - 1;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_customArr[i].Value == value as string)
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _customArr = null;
            Count = 0;
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_customArr[i].Value == value as string)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            if (index < Count && index >= 0)
            {
                Count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _customArr[i] = _customArr[i - 1];
                }

                _customArr[index] = new Custom(value);
                _customArr[index].Next = _customArr[index + 1];

                if (index == 0)
                {
                    _head = _customArr[index];

                    if (_head == null)
                    {
                        _tail = null;
                    }
                }
                else
                {
                    _customArr[index - 1].Next = _customArr[index];
                }


            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _customArr[i] = _customArr[i + 1];
                }

                _customArr[index - 1].Next = _customArr[index];
                _customArr[Count - 1] = null;

                if (index == 0)
                {
                    _head = _head.Next;
                }

                if (_head == null)
                {
                    _tail = null;
                }

                Count--;
            }
        }

        public void CopyTo(Array array, int index)
        {
            Custom current = _head;

            while (current != null)
            {
                array.SetValue(current, index++);
                current = current.Next;
            }
        }

     
        #endregion

        private Custom[] NewArrayWithCopy(Custom[] oldArray, int newSize = 2)
        {
            Custom current = oldArray[0];
            int index = 0;
            _size *= newSize;
            Custom[] newCustom = new Custom[_size];

            while (current != null)
            {
                newCustom[index] = current;
                current = current.Next;
            }

            return newCustom;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Custom
    {
        public Custom Next { get; set; }
        public string Value { get; }

        public Custom(object value)
        {
            Value = value as string;
        }
    }
}

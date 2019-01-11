using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ISTC.ThirdStage.Advance.Collection.Collection01
{
    class WesternAlphabetEnumerator : IEnumerator<string>
    {

        private IEnumerable<string> _alphabet;
        public int _position;
        private int _max;

        public WesternAlphabetEnumerator(IEnumerable<string> alphabet)
        {
            _alphabet = alphabet;
            _position = -1;
            _max = _alphabet.Count() - 1;
        }

        public string Current => _alphabet.ElementAt(_position);

        object IEnumerator.Current => this.Current;

        public bool MoveNext()
        {
            Console.WriteLine(_position);
            if (_position < _max)
            {
                _position ++;
                return true;
            }
            return false;
        }

        void IEnumerator.Reset()
        {
            _position = 6;
        }

       
        public void Dispose() { }
    }
}

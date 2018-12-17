using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection
{
    class WesternAlphabetEnumerator : IEnumerator<string>
    {

        private IEnumerable<string> _alphabet;
        private int _position;
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
            if (_position < _max)
            {
                _position += 1;
                return true;
            }
            return false;
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose() { }
    }
}

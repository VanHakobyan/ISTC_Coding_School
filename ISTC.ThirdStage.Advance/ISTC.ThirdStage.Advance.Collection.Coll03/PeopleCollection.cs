using System.Collections;

namespace ISTC.ThirdStage.Advance.Collection.Coll03
{
    public class PeopleCollection : IEnumerable, IEnumerator
    {
        private int _position = -1;

        private readonly People[] _peoples;

        public PeopleCollection()
        {
          
            string name = "A";
            _peoples = new People[10];
            for (var i = 0; i < _peoples.Length; i++)
            {
                _peoples[i] = new People { Age = i, Name = $"{name} {i}" };
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_position < _peoples.Length)
            {
                _position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get { return _peoples[_position]; }
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace ISTC.ThirdStage.Advance.Collection.Collection01
{
    public class WesternAlphabet : IEnumerable<string>
    {

        IEnumerable<string> _alphabet;

        public WesternAlphabet()
        {
            _alphabet = new string[] { "A", "B", "C",
                "D", "E", "F", "G",
                "H", "I", "J", "K",
                "L", "M", "N", "O",
                "P", "Q", "R", "S",
                "T", "U", "V", "W",
                "X", "Y", "Z" };
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new WesternAlphabetEnumerator(_alphabet);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

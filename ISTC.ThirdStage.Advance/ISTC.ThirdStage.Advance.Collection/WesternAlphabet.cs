using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Collection
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

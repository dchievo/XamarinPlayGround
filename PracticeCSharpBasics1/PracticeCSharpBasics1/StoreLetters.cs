using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharpBasics1
{
    class StoreLetters
    {
        private LinkedList<string> _lettersContainer;
        public LinkedList<string> LettersContainer
        {
            get
            {
                return _lettersContainer;
            }
            set
            {
                _lettersContainer = value;  
            }

        }


        public StoreLetters()
        {
            LettersContainer = new LinkedList<string>(generateLettersArray());
        }

        private string[] generateLettersArray()
        {
            string[] Letters = new string[] { "A", "B", "C" };
                

            return Letters;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharpBasics1
{
    class Singleton
    {
        private static Singleton singleton = new Singleton();
        private LinkedList<string> _storeLetters;
        public LinkedList<string> StoreLetters
        {
            get
            {
                return _storeLetters;
            }
            set
            {
                _storeLetters = value;
            }
        }



        private Singleton()
        {
            StoreLetters = new StoreLetters().LettersContainer;
        }

        public void forLoop()
        {
            foreach (var number in StoreLetters)
            {
                Console.WriteLine(number);                
            }
            Console.ReadLine();
        }

        public static Singleton getInstance()
        {
            return singleton;
        }
    }
}

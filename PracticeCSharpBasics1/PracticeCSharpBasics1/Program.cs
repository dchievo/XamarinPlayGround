using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharpBasics1
{
    class Program
    {

        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();

            singleton.forLoop();
            singleton.GetHashCode();
            Console.ReadLine(); asdfasdf
        }

    }
}

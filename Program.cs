using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfr_Cezara
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var c in Console.ReadLine())
            {
                Console.Write(Convert.ToChar((c - 'a' + 1) % ('z' - 'a' + 1) + 'a'));
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
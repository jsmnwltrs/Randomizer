using System;
using System.Collections.Generic;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatenumbers = new Generator();
            generatenumbers.generateNums();
            Console.ReadLine();
        }
    }
}

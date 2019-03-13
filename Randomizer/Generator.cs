using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    class Generator
    {
        Random random = new Random();
        public List<int> ranlist = new List<int>();
        public List<int> squaredList = new List<int>();
        public string mynumbers = "";
        public string mystring = "";
        public string removedOdds = "";

        public void generateNums ()
        {
            for (int i = 0; i< 20; i++)
            {
                var mynum = random.Next(50);
                ranlist.Add(mynum);
            }

            foreach (var number in ranlist)
            {
                mynumbers += number + ",";
            }

            foreach (var number in ranlist)
            {
                var squaredNumbers = number * number;
                squaredList.Add(squaredNumbers);
                mystring += squaredNumbers + ",";
            }

            Console.WriteLine($"My Random numbers: {mynumbers.TrimEnd(',')}");
            Console.WriteLine($"My Random numbers squared: {mystring.TrimEnd(',')}");

            squaredList.RemoveAll(i => i % 2 != 0);

            foreach (var number in squaredList)
            {
                removedOdds += number + ",";
            }

            Console.WriteLine($"My Random numbers squared without odds: {removedOdds.TrimEnd(',')}");
        }
    }
}

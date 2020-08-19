using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<int> Randos = new List<int>();

            List<int> RandosSquared = new List<int>();


            Console.WriteLine("\r\n Random Numbers: \r\n");

            for (var i = 0; i < 20; i++)
            {
                int randInt = rand.Next(0, 50);
                Randos.Add(randInt);
                Console.WriteLine($"{randInt}");
            }

            Console.WriteLine("\r\n Randos Squared: \r\n");

            foreach (var i in Randos)
            {
                int sq = i * i;
                RandosSquared.Add(sq);
                Console.WriteLine($"{sq}");
            }

            Console.WriteLine("\r\n Randos Square minus Odd numbers: \r\n");

            foreach (var i in RandosSquared)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }

            }

            
        }
    }
}

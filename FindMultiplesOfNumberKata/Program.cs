using System;
using System.Collections.Generic;

namespace FindMultiplesOfNumberKata
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindMultiples(5, 25).ToString());
        }
        public static List<int> FindMultiples(int integer, int limit)
        {
            //infantile error handling
            List<int> multiples = new List<int>();
            if (integer <= 0 | limit <= 0)
            {
                return new List<int>(0);
            }
            //logic
            for (int i = integer; i <= limit; i = i + integer)
            {
                multiples.Add(i);
            }

            return multiples;
        }
    }
}

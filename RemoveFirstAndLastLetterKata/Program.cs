using System;

namespace RemoveFirstAndLastLetterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveFirstAndLast("Hello World"));
            Console.WriteLine(RemoveFirstAndLast("eloquent"));
            Console.WriteLine(RemoveFirstAndLast("country"));
            Console.WriteLine(RemoveFirstAndLast("person"));
            Console.WriteLine(RemoveFirstAndLast("OK"));
        }
        public static string RemoveFirstAndLast(string s)
        {
            return s.Remove(s.Length - 1, 1).Remove(0, 1);
        }
    }
}
//"eloquent" => "loquen"
//"country" => "ountr"
//"person" => "erso"
//"OK" => ""
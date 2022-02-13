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
        public static string RemoveFirstAndLast(string word)
        {
            string result = word;
            result = result.Remove(result.Length - 1, 1).Remove(0, 1);
            return result;
        }
    }
}
//"eloquent" => "loquen"
//"country" => "ountr"
//"person" => "erso"
//"OK" => ""
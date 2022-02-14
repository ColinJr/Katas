using System;
using System.Collections.Generic;

namespace TenIntsToCellPhoneStringKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumArrayToString(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Console.WriteLine(NumArrayToString(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })); 
            //new int[]{1,2,3,4,5,6,7,8,9,0} => "(123) 456-7890"
            //new int[]{1,1,1,1,1,1,1,1,1,1} => "(111) 111-1111"
        }
        public static string NumArrayToString(int[] nums)
        {
            string numstring = String.Join("", new List<int>(nums).ConvertAll(i => i.ToString()).ToArray());
            string a = numstring.Substring(0, 3);
            string b = numstring.Substring(3, 3);
            string c = numstring.Substring(6, 4);
            Console.WriteLine("string a is " + a);
            Console.WriteLine("string b is " + b);
            Console.WriteLine("string c is " + c);
            return numstring;
        }
    }
}

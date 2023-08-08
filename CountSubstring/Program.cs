using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountSubstring
{
    class Program
    {
        /// <summary>
        /// program to count substring of length 2 that appears at the end in given string. Do not count the end substring.
        /// </summary>
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            int n=str.Length;
            string substr=str.Substring(n-2,2);

            //Regex.Matches().Count to count number of substring in a string
            int count = Regex.Matches(str, substr).Count;
       
            Console.WriteLine(count-1);

            Console.Read();
        }
    }
}

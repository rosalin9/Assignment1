using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFrom2String
{
    /// <summary>
    /// program to create a string using the two given strings s1, s2 and the new format will be s1s2s2s1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();
            // using string join method to join two strings
            Console.WriteLine(String.Join("",s1, s2, s2, s1));

            Console.Read();
        }
    }
}

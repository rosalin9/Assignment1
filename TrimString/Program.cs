using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimString
{
    /// <summary>
    /// program to trim first and last character of a string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();

            Console.WriteLine(str.Trim(str.First(),str.Last()));

            Console.Read();
        }
    }
}

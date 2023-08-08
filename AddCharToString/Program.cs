using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCharToString
{
    class Program
    {
        //Program to add last char of a string to the front and back of the string
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            //String variable.Last() will give the last character of a given string
            char c = str.Last();
            Console.WriteLine(c + str + c);

            Console.ReadLine();
        }
    }
}

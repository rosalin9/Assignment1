using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyOfString
{
    class Program
    {
        //Program to print first two charachters of a string four times
        static void Main(string[] args)
        {
            string name=Console.ReadLine();

            //if length of string is less than 2 then print the string directly in console
            if (name.Length < 2)
                Console.WriteLine(name);
            else 
            {
                for (int i = 0; i < 4; i++) 
                {
                
                    Console.Write(name.Substring(0,2));
                }
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// program to check whether a given strin begins with 'F' then return Fizz or ends with 'B' then return Buzz.if both F and B present then return FizzBuzz else return normal string. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            FizzBuzz(str);

            Console.Read();
        }
        static void FizzBuzz(string name)
        {
            if (name.First() == 'F' && name.Last() == 'B')
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (name.First() == 'F')
            {
                Console.WriteLine("Fizz");
            }
            else if (name.Last() == 'B')
            {
                Console.WriteLine("Buzz");
            }
            else
                Console.WriteLine(name);
        }
    }
}

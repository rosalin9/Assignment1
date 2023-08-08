using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwo
{
    class Program
    {
        //Method for Sum of two numbers
        public int Sum(int x, int y)
        {
            //if both the numbers are same then return triple of sum
            if (x == y)
            {
                return 3 * (x + y);
            }
            else
            {
                return x + y;
            }
        }
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Program obj= new Program(); 

            Console.WriteLine(obj.Sum(a, b));

            Console.ReadLine();


        }
    }
}

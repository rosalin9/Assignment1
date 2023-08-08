using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDifference
{
    class Program
    {
        //Program for absolute difference of number 51 and n
        public int AbsDiff(int y)
        {
            int x = 51;
            //if n is greater than 51 then return triple the absolute difference
            if (y>x)
            {
                return Math.Abs(3*(x-y));
            }
            else
            {
                return x - y;
            }
        }
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());

            Program Obj = new Program();
            Console.WriteLine(Obj.AbsDiff(n));

            Console.ReadLine();
        }
    }
}

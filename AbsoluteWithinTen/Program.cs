using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteWithinTen
{
    class Program
    {
        /// <summary>
        /// program to return true if the number is 10 of 100 or 10 of 200
        /// </summary>
        public static bool Check(int n)
        {
            int res=Math.Abs(100-n);
            int res1=Math.Abs(200-n);
            if (res <= 10 || res1 <= 10)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Check(num));

            Console.Read();

        }
    }
}

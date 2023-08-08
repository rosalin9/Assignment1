using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMultiple
{
    class Program
    {
        //program to check if a given number is multiple of 3 or 7
        public bool Multiple(int x)
        {
            if ((x % 3 == 0) || (x % 7 == 0))
                return true;
            else 
                return false;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Program Obj = new Program();
            Console.WriteLine(Obj.Multiple(a));

            Console.ReadLine();
        }
    }
}

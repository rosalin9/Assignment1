using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVal
{
    class Program
    {
        //Program to return True if sum of two numbers is 30 or if one of the number is 30
        public bool Check(int x, int y)
        {
            if ((x+y)==30 || x==30 || y==30)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Program Obj = new Program();

            Console.WriteLine(Obj.Check(a,b));

            Console.ReadLine();
        }
    }
}

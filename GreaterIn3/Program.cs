using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterIn3
{
    /// <summary>
    /// program to check if y is greater than x and z is greater than y
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            int z=Convert.ToInt32(Console.ReadLine());

            if (y > x && z>y)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

            Console.Read();
        }
    }
}

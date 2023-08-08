using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckForz
{
    /// <summary>
    /// program to return true if the input string has char 'z' from position 2 to 4
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            string val=Console.ReadLine();
            int count = 0;
            int n = val.Length;
            if (n >= 4)
            {
                for (int i = 1; i <=3; i++)
                {
                    if (val[i] == 'z')
                        count++;
                }
            }
            else if (n>=2)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    if (val[i] == 'z')
                        count++;
                }
            }
            if (count>0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            

            Console.ReadLine();
        }
    }
}

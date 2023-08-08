using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NCopyOfString
{
    class Program
    {
      
        /// <summary>
        /// program to create a string which is copy of a given number of times of the string
        /// </summary>
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            string[] token = str.Split(' ');
            int num = Convert.ToInt32(token[1]);
            StrCopy(token[0],num);

            Console.ReadLine();
        }
        public static void StrCopy(string name, int n)
        {
            
            string res = name;
            if(n>1)
            {
                //String Concatination
                for (int i = 2; i <= n; i++)
                {
                    res=String.Concat(res,name);
                }
                Console.WriteLine(res);
            }
            else if (n == 1)
                Console.WriteLine(res);
        }

    }
    
}

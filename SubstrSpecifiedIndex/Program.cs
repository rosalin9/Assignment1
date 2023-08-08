using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstrSpecifiedIndex
{
    class Program
    {
        /// <summary>
        /// program to create a string of characters at indexes 0,1,4,5,8,9,....
        /// </summary>
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            char[] strchar = str.ToCharArray();
            string res ="";
            for(int i = 0; i < strchar.Length; i+=4)
            {
                res = String.Concat(res, strchar[i], strchar[i+1]);
            }
            Console.WriteLine(res);

            Console.Read();
        }
    }
}

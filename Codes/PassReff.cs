using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class PassReff
    {

        static void Main(string[] args)
        {

            int num = 10;
            Console.WriteLine($"Before: {num}");
            MethodByReff(ref num);
            Console.WriteLine($"After:{num}");
            Console.ReadLine();
        }
        static void MethodByReff(ref int value)
        {
            value = 20;
            Console.WriteLine($"Inside:{value}");
        }


    }
}
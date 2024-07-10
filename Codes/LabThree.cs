using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class LabThree
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            Console.WriteLine("Please enter the number of size of multiplication");
            int n=int.Parse(Console.ReadLine());
            /*for (i = 1; i <= n; i++)
            {
                //Console.Write($"{i,4}");
                for (j = 1; j <= n; j++)
                {
                    Console.Write($"{i*j}");

                }
            }*/
            for (i = 1; i < n; i++)
            {
                Console.WriteLine($"{i,4}");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',n*4+4));
            for (i = 1; i < n;i++)
            {
                Console.Write($"{i,4}");
                for (j = 1; j < n;j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class LabOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab One: Read() Vs Readline and Write() vs WriteLine");
            Console.WriteLine("WriteLine Example");
            Console.Write("Write Example");//Donot break line
            Console.WriteLine("Readline Example");//BREAK LINE After write display
            Console.WriteLine("Enter a name");
            string A = Console.ReadLine();//Read line 
            Console.Write("Write() Example.donot break line    Hello" + A);
            Console.WriteLine("WriteLine() breakline Example after display.    Hello" + A);
            Console.Write("Write() ExampleHello     " + A);

            Console.WriteLine("Read() Example");
                Console.WriteLine("Enter a number");
            int x= Console.Read();//gives asci value and take integer as input
            Console.WriteLine("The entered number is    " + x);
        }
    }
}

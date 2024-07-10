using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class LabTwo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Display Calculator");
            numer1:
            Console.WriteLine("Enter first Number");
            string val1 = Console.ReadLine();
            int x;
            bool isnum1 = int.TryParse(val1, out x);
            if (isnum1)
            {
                numer2:
                //double x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                string val2 = Console.ReadLine();
                int y;
                bool isnum2 = int.TryParse(val2, out y);
                if (isnum2)
                {
                    //double y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter an Operator (+,-,*,/):");
                    string Operation = Console.ReadLine();

                    double result = 0;
                    switch (Operation)
                    {
                        case "+":
                            result = x + y;
                            Console.WriteLine("The sum of First and Second is: " + result);
                            break;
                        case "-":
                            result = x - y;
                            Console.WriteLine("The Subtract of First and Second is: " + result);
                            break;
                        case "*":
                            result = x * y;
                            Console.WriteLine("The Multiply of First and Second is: " + result);
                            break;
                        case "/":
                            if (y != 0)
                            {
                                result = x / y;
                                Console.WriteLine("The Division of First and Second is: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Not Diviziable by 0");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Operation");
                            break;
                    }
                    Console.ReadLine();
                }
                Console.WriteLine("Please enter a valid number");
                goto numer2;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                goto numer1;
            }
        }
    }
}

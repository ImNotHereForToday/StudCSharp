using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            Console.WriteLine("Please input the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please choose the following variable '+' , '-' , '*;' , '/' ");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition:" + res);
                    if (res < 50 && res != 37 && res >= 32)
                    {
                        Console.WriteLine("Works!");
                    }
                    else if (res == 0 / 15)
                    {
                        Console.WriteLine("Partly working!");
                    }
                    else
                    {
                        Console.WriteLine("Does’t work");
                    }


                    if (res % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                    break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Substraction:" + res);
                    if (res < 50 && res != 37 && res >= 32)
                    {
                        Console.WriteLine("Works!");
                    }
                    else if (res == 0 / 15)
                    {
                        Console.WriteLine("Partly working!");
                    }
                    else
                    {
                        Console.WriteLine("Does’t work");
                    }

                    if (res % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }

                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication:" + res);
                    if (res < 50 && res != 37 && res >= 32)
                    {
                        Console.WriteLine("Works!");
                    }
                    else if (res == 0 / 15)
                    {
                        Console.WriteLine("Partly working!");
                    }
                    else
                    {
                        Console.WriteLine("Does’t work");
                    }

                    if (res % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }

                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Division:" + res);
                    if (res < 50 && res != 37 && res >= 32)
                    {
                        Console.WriteLine("Works!");
                    }
                    else if (res == 0 / 15)
                    {
                        Console.WriteLine("Partly working!");
                    }
                    else
                    {
                        Console.WriteLine("Does’t work");
                    }

                    if (res % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }

                    break;
                default:
                    Console.WriteLine("Operation is not present in the list of allowed operations");
                    break;


                   

            }
        }
    }
}

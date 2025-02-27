using System;

class Calculations
{
    public void RunCalculations()
    {
       
            Console.WriteLine("Please input the first number");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input for the first number.");
                return;
            }

            Console.WriteLine("Please input the second number");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input for the second number.");
                return;
            }

            Console.WriteLine("Please choose the following variable '+' , '-' , '*' , '/' ");
            string operation = Console.ReadLine();

            int res;
            switch (operation)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition: " + res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction: " + res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication: " + res);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    res = num1 / num2;
                    Console.WriteLine("Division: " + res);
                    break;
                default:
                    Console.WriteLine("Operation is not present in the list of allowed operations");
                    return;
            }

            CheckResult(res);
            CheckEvenOdd(res);
        }

        static void CheckResult(int res)
        {
            if (res < 50 && res != 37 && res >= 32)
            {
                Console.WriteLine("Works!");
            }
            else if (res == 0 || res == 15)
            {
                Console.WriteLine("Partly working!");
            }
            else
            {
                Console.WriteLine("Doesn't work");
            }
        }

        static void CheckEvenOdd(int res)
        {
            if (res % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }

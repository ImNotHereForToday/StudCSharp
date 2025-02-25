using System;
using System.Linq;

class LoopsArrays
{
    static void Main(string[] args)
    {
        // CalculationAndMultiplication();
        //Arrays();
        //Calculate_2048_Divided_By_2();
        //Array_Of_Strings();
        //Calculate_Array_Numbers();
        //Array_Of_Max_Min_Numbers();
        //Array_Asscending_Numbers();
        Array_Two_Dimensional();
    }


    public static void CalculationAndMultiplication()
    {
        Console.WriteLine("Please input positive number");
        int input = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < input; i++)
        {
            Console.WriteLine(i);

        }
        int numberMulti = 3;

        while (numberMulti > 0)
        {
            Console.WriteLine($"{input} * 3 = {input * numberMulti}");

            if (input == 0)
            {
                Console.WriteLine("Why are u multiplying a 0 :)");
                break;
            }
            break;
        }
    }
    public static void Arrays()
    {
        int[] numbers = { 3, 5, 9, 8, 15 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
    public static void Calculate_2048_Divided_By_2()
    {
        int count = 0;
        double num = 2048;

        while (num >= 10)
        {
            num /= 2;
            count++;
        }

        Console.WriteLine("Number of divisions: " + count);
    }
    public static void Array_Of_Strings()
    {
        string[] strings = { "Word", "two", "Hello", "LT" };

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine($"{strings[i]}");

            if (strings[i] == "Hello")
            {
                Console.WriteLine("\nLabas!");
                break;
            }
        }
    }
    public static void Calculate_Array_Numbers()
    {

        int[] numbers = { 1, 2, 5, 6, 7, 9, 10 };
        int sum = numbers[0] + numbers[numbers.Length - 1];

        Console.WriteLine(sum);
    }
    public static void Array_Of_Max_Min_Numbers()
    {
        int[] numbers = { 4, 2, 1, 6, 15, 9, 3 };

        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
            if (num < smallest)
            {
                smallest = num;
            }

            Console.WriteLine("Smallest number :" + smallest);
            Console.WriteLine("largest number :" + largest);
        }
    }
    public static void Array_Asscending_Numbers()
    {
        int[] arr = { 2, 3, 4, 5, 6, 7, 1 };

        bool didSwap;
        do
        {
            didSwap = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                    didSwap = true;
                }
            }
        } while (didSwap);
        for (int i = 0; i != arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void Array_Two_Dimensional()
    {
        int[,,] numbers = new int[,,] { { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9, } } };

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int k = 0; k < numbers.GetLength(2); k++)
                {
                    Console.Write($"{numbers[i, j, k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}






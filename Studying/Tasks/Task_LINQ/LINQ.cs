using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying.Tasks.Task_LINQ
{
    public class LINQ
    {

        public void LINQS_Task1()
        {
            List<int> intList = new List<int>
            { 0, 1 , 2, 3, 4, 5, 6, 7, 8, 9, };

            var QuerySyntax = from number in intList
                              where number % 2 == 0
                              select number;

            foreach (var number in QuerySyntax)
            {
                Console.Write(number);
            }


        }

        public void LINQS_Task2()
        {

            List<int> intList = new List<int>
            { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };


            var QuerySyntax = from number in intList
                              where number > 0
                              where number < 11
                              select number;

            foreach (var number in QuerySyntax)
            {
                Console.Write(number + " ");
            }
        }
        public void LINQS_Task3()
        {
            List<int> intList = new List<int>
            { 9 , 8 , 6 , 5 };

            var QuerySyntax = from number in intList
                              where number * number > 20
                              select new { number, Square = number * number };

            foreach (var number in QuerySyntax)
            {
                Console.WriteLine(number);
            }

        }
        public void LINQS_Task4()
        {
            List<int> intList = new List<int>
            { 5 , 5, 5 , 9 , 9 , 1 };

            var QuerySyntax = from number in intList
                              group number by number into numberGroup
                              select new { numberGroup.Key, Count = numberGroup.Count() };

            foreach (var number in QuerySyntax)
            {
                Console.WriteLine($"Number {number.Key} appears {number.Count} times");
            }
        }
        public void LINQS_Task5()
        {
            List<string> stringList = new List<string>
            {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var QuerySyntax = from city in stringList
                              where city.StartsWith("A") && city.EndsWith("M")
                              select city;

            foreach (var city in QuerySyntax)
            {
                Console.WriteLine(city);
            }
        }
        public void LINQS_Task6()
        {
            List<int> intList = new List<int>
            { 5, 7, 13, 24, 6, 9, 8, 7 };

            int numberOfRecords = 3;

            var QuerySyntax = (from number in intList
                               orderby number descending
                               select number).Take(numberOfRecords);

            foreach (var number in QuerySyntax)
            {
                Console.Write(number + ", ");
            }
        }
        public void LINQS_Task7()
        {
            List<string> stringList = new List<string>
            {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var QuerySyntax = from city in stringList
                              orderby city.Length, city ascending
                              select city;

            foreach (var city in QuerySyntax)
            {
                Console.WriteLine(city);
            }
        }
        public void LINQS_Task8()
        {
            List<string> strings = new List<string>
            { "Biscuit", "Brade", "Honey", "Butter" };

            var QuerySyntax = from stringList in strings
                              orderby stringList ascending // stringList.IsNormalized() <- was using this method to sort the strings but it's not needed.
                              select stringList;

            foreach(var stringList in QuerySyntax)
            {
                Console.WriteLine(stringList);
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Studying.Tasks.Task_Collections
{
    public class Collections
    {
        public class ListTask
        {

            public List<int> Items { get; private set; } = new List<int>();

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> names = new List<string>() { "John", "Doelino", "J", "Helicopter" };

            public void NumberList()
            {
                Console.Write($"List of numbers:");
                foreach (var num in numbers)
                {
                    Console.Write($" {num}");
                }

            }
            public void StringList()
            {
                Console.WriteLine($"\nList of names: ");
                foreach (var str in names)
                {
                    Console.WriteLine($" {str}");
                }
            }

            public void SumEvenNumbers()
            {
                int sum = 0;
                Console.WriteLine($"\n");
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
                Console.WriteLine($"Sum of even numbers: {sum}");

            }

            public void SearchingForString()
            {
                Console.WriteLine($"Enter a name to search for");
                string search = Console.ReadLine();

                if (names.Exists(name => name.Equals(search, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Name {search} is found in the list");
                }
                else
                {
                    Console.WriteLine($"Name {search} is not found in the list");
                }
            }
        }

        //#############################################################################################################

        public class LinkedListTask
        {
            public List<int> Items { get; private set; } = new List<int>();

            public LinkedList<int> numbers = new LinkedList<int>(new List<int>() { 2, 4, 3, 2, 8, 2, 5, 1, 2 });

            public LinkedList<int> List1 = new LinkedList<int>(new List<int>() { 1, 3, 4, 7, 12 });
            public LinkedList<int> List2 = new LinkedList<int>(new List<int>() { 1, 5, 7, 9 });

            public void InsertInOccurance(int firstItem, int secondItem)
            {

                LinkedListNode<int> node = numbers.First;


                while (node != null)
                {

                    if (node.Value == firstItem)
                    {
                        numbers.AddAfter(node, secondItem);

                        node = node.Next;
                    }
                    else
                    {
                        node = node.Next;
                    }

                }
            }

            public LinkedList<int> MergeLists()
            {
                LinkedList<int> commonList = new LinkedList<int>();
                LinkedListNode<int> node1 = List1.First;


                while (node1 != null)
                {
                    LinkedListNode<int> node2 = List2.First;

                    while (node2 != null)
                    {
                        if (node1.Value == node2.Value)
                        {
                            commonList.AddLast(node1.Value);
                            break;
                        }
                        node2 = node2.Next;
                    }
                    node1 = node1.Next;
                }

                return commonList;
            }

            public void DisplayList(LinkedList<int> list)
            {
                foreach (var num in list)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            public void DisplayList()
            {
                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }

        //#############################################################################################################

        public class QueueAndStack
        {
            Queue<int> numbers = new Queue<int>();

            public void queue1()
            {
                numbers.Enqueue(10);
                numbers.Enqueue(5);
                numbers.Enqueue(20);

                Console.WriteLine(" ");

                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }

            }
            public QueueAndStack()
            {
                numbers = new Queue<int>();
            }



            public void GetMaxValue()
            {
                int maxValue = numbers.Dequeue();

                numbers.Enqueue(maxValue);

                for (int i = 0; i < numbers.Count; i++)
                {
                    int value = numbers.Dequeue();

                    if (value > maxValue)
                    {
                        maxValue = value;
                    }
                    numbers.Enqueue(value);
                }
                Console.WriteLine($"\nMax value: {maxValue}");

            }
            public void DeleteMaxValue()
            {

                int maxValue = numbers.Dequeue();

                numbers.Enqueue(maxValue);

                for (int i = 0; i < numbers.Count; i++)
                {
                    int value = numbers.Dequeue();

                    if (value > maxValue)
                    {
                        maxValue = value;
                    }
                    numbers.Enqueue(value);

                    while (numbers.Peek() == maxValue)
                    {
                        numbers.Dequeue();
                    }

                }
                Console.WriteLine($"\nMax value was deleted: {maxValue}");
            }

            public void ReverseQueue()
            {
                Stack<char> stack = new Stack<char>();

                Console.WriteLine("Please input 3 letters");

                Console.Write("Enter first letter: ");
                char letter1 = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter second letter: ");
                char letter2 = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter third letter: ");
                char letter3 = Console.ReadKey().KeyChar;
                Console.WriteLine();


                stack.Push(letter1);
                stack.Push(letter2);
                stack.Push(letter3);

                Console.WriteLine("\nReversed letters: ");
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop() + " ");

                }
            }
        }
        //#############################################################################################################

        public class DictionaryTask
        {
            public void DictionaryTasks()
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("John", "30");
                dictionary.Add("Jane", "25");
                dictionary.Add("Thomas", "27");

                var firstItemBefore = dictionary.First();
                Console.WriteLine("\nFirst item before modifications -> Name: " + firstItemBefore.Key + ", Age: " + firstItemBefore.Value);

                dictionary["John"] = "Andrew";
                dictionary["30"] = "25";
                Console.WriteLine("\nJohn's name was changed to Andrew  ->  " + dictionary["John"] + "\nAnd his new age is : " + dictionary["30"]);

                Console.WriteLine("\nItem after modifications -> Name: " + dictionary["John"] + ", Age: " + dictionary["30"]);
            }
            public void DictionaryTask2()
            {
                List<int> intList = new List<int>() { 2, 3, 6, 4, 1, 7, 8, 10, 21, 0 };
                List<string> stringList = new List<string>() { "h", "j", "g", "a", "v", "i", "m", "c", "s", "v" };

                intList.Sort();
                stringList.Sort();
                stringList.Reverse();

                Console.WriteLine("\nSorted int list: " + string.Join(", ", intList));
                Console.WriteLine("\nSorted string list: " + string.Join(", ", stringList));

                Dictionary<int, string> dictionary = new Dictionary<int, string>();

                for (int i = 0; i < intList.Count; i++)
                {
                    dictionary.Add(intList[i], stringList[i]);
                }
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }
            }

            public class City
            {
                public int Population { get; set; }
                public double Area { get; set; }

            }


            public void DictionaryTask3()
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();

                City Capital = new City { Population = 60000, Area = 253.01 };
                City City1 = new City { Population = 50000, Area = 203.01 };
                City City2 = new City { Population = 30000, Area = 153.01 };
                City City3 = new City { Population = 20000, Area = 100.01 };
                City City4 = new City { Population = 10000, Area = 50.01 };

                dictionary.Add("Vilnius", Capital);
                dictionary.Add("Kaunas", City1);
                dictionary.Add("Klaipeda", City2);
                dictionary.Add("Utena", City3);
                dictionary.Add("Taurage", City4);

                var sortedDictionaryArea = dictionary.OrderByDescending(item => ((City)item.Value).Area);
                Console.WriteLine("\nSorting by population : Descending ");
                foreach (var item in sortedDictionaryArea)
                {
                    Console.WriteLine($"City: {item.Key}, Info: Population = {((City)item.Value).Population}, Area = {((City)item.Value).Area}");
                }

                var sortedDictionaryPopulation = dictionary.OrderBy(item => ((City)item.Value).Population);
                Console.WriteLine("\nSorting by population : Ascending ");
                foreach (var item in sortedDictionaryPopulation)
                {
                    Console.WriteLine($"City: {item.Key}, Info: Population = {((City)item.Value).Population}, Area = {((City)item.Value).Area}");
                }

                var sortedDictionaryTotalPopulation = dictionary.Sum(item => ((City)item.Value).Population);
                Console.WriteLine("\nTotal sum of the pupulation is : " + sortedDictionaryTotalPopulation);


            }
        }
    }
    }




using Studying.Tasks.Task_Loops_Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying.Program
{
    class Program_Generic : GenericArray<int>
    {
        public void RunGenericArrayTask_Generics()
        {
            GenericArray<int> intArray = new GenericArray<int>();

            intArray.AddItem(5);
            intArray.AddItem(10);
            intArray.AddItem(15);
            intArray.AddItem(20);
            intArray.AddItem(25);
            intArray.AddItem(30);

            Console.WriteLine("\nItems:");
            intArray.DisplayItems();

            intArray.RemoveIndex(1);

            Console.WriteLine("\nItems:");
            intArray.DisplayItems();

            Console.WriteLine("");
            intArray.GetSpecificIndex(3);

            Console.WriteLine("\nCount:");
            intArray.GetCount();

           }
        }


    }


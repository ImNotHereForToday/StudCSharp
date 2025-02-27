using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying.Tasks.Task_Loops_Arrays
{
    using System;
    using System.Reflection;


    public class GenericArray<T>
    {
        public List<T> Items { get; private set; } = new List<T>();


        public void AddItem(T item)
        {
            Items.Add(item);
        }


        public bool RemoveIndex(int index)
        {
            if (index < 0 || index >= Items.Count)
            {
                Console.WriteLine($"Index {index} is not in range");
                return false;
            }

            Items.RemoveAt(index);
            return true;
        }

        public void DisplayItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public void GetCount()
        {

            Console.WriteLine($"Total items in the list: {Items.Count}");

        }
        public void GetSpecificIndex(int index)
        {

            if (index < 0 || index >= Items.Count)
            {
                Console.WriteLine($"Index {index} is not in range");
                return;
            }
            T item = Items[index];
            Console.WriteLine($"Item at index {index} is : {item}");
        }
    }
}

using Studying.Tasks.Task_Collections;
using Studying.Tasks.Task_Loops_Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying.Program
{
    class Program_Collections : Collections
    {
        public void RunListTask_Collections()
        {
            ListTask ListTask = new ListTask();
            ListTask.NumberList();
            ListTask.SumEvenNumbers();
            ListTask.StringList();
            ListTask.SearchingForString();
        }
        public void RunLinkedListTask_Collections()
        {
            LinkedListTask LinkedListTask = new LinkedListTask();
            LinkedList<int> mergedList = LinkedListTask.MergeLists();

            LinkedListTask.InsertInOccurance(2, 10);
            LinkedListTask.DisplayList();

            LinkedListTask.MergeLists();
            LinkedListTask.DisplayList(mergedList);
        }
        public void RunQueueAndStack_Collections()
        {
            QueueAndStack QueueAndStack = new QueueAndStack();
            QueueAndStack.queue1();
            QueueAndStack.GetMaxValue();
            QueueAndStack.DeleteMaxValue();
            QueueAndStack.GetMaxValue();
            //QueueAndStack.queue1();
            QueueAndStack.ReverseQueue();

        }

        public void RunDictionary_Collections()
        {
            DictionaryTask DictionaryTask = new DictionaryTask();
            DictionaryTask.DictionaryTasks();

        }
        public void RunDictionary_Collections_Task2()
        {
            DictionaryTask DictionaryTask = new DictionaryTask();
            DictionaryTask.DictionaryTask2();
        }
        public void RunDictionary_Collections_Task3()
        {
            DictionaryTask DictionaryTask = new DictionaryTask();
            DictionaryTask.DictionaryTask3();
        }
    }
}

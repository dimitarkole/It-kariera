using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedStackTask();
        }

        static void LinkedStackTask()
        {
            LinkedStack<int> LinkedStack = new LinkedStack<int>();
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                LinkedStack.Push(i);
                Console.WriteLine(string.Join(" ", LinkedStack.ToArray()));
                Console.WriteLine("count= "+ LinkedStack.Count);

            }

            for (int i = 0; i < n; i++)
            {
                LinkedStack.Pop();
                Console.WriteLine(string.Join(" ", LinkedStack.ToArray()));
            }
        }

        static void LinkedQueueTask()
        {
            LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                linkedQueue.Enqueue(i);
                Console.WriteLine(string.Join(" ", linkedQueue.ToArray()));
            }

            for (int i = 0; i < n; i++)
            {
                linkedQueue.Dequeue();
                Console.WriteLine(string.Join(" ", linkedQueue.ToArray()));
            }
        }

/*
        static void ReversedListTask()
        {
            ReversedList<int> myReversedList = new ReversedList<int>();
            myReversedList.Add(1);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.Add(2);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.Add(3);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.Add(4);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.Add(5);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.Add(6);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.RemoveAt(0);
            Console.WriteLine(myReversedList.ToString());
            Console.WriteLine(myReversedList.Count());


            myReversedList.RemoveAt(0);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.RemoveAt(0);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.RemoveAt(0);
            Console.WriteLine(myReversedList.ToString());

            myReversedList.RemoveAt(0);
            Console.WriteLine(myReversedList.ToString());

            Console.WriteLine(myReversedList.Count());
        }

        static void ArrayStack()
        {
            ArrayStack<int> myStack = new ArrayStack<int>();

        }

        static void ArrListFunction()
        {
            ArrayList<int> list = new ArrayList<int>();
            list.Add(5);
            //Console.WriteLine(list[0]);
            list[0] = list[0] + 1;
            int element = list.RemoveAt(0);
            Console.WriteLine(element);
        }*/
    }
}

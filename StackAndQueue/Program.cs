using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- My Queue ----------------");

            #region     My Queue 
            MyQueue myQueue = new MyQueue();
            myQueue.EnQueue(5);
            myQueue.EnQueue(6);
            myQueue.EnQueue(7);
            myQueue.EnQueue(8);
            myQueue.EnQueue(9);

            //myQueue.DeQueue();
            int y = myQueue.DeQueue();

            myQueue.ShowQueue();
            #endregion

            Console.WriteLine("\n-------------- My Stack ----------------");
            MyStack myStack = new MyStack();
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);

            myStack.Pop();
            //int k = myStack.Pop();

            myStack.ShowStack();





        }
    }
}

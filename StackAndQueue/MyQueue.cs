using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class MyQueue
    {
        Stack<int> stack1;
        public MyQueue()
        {
            stack1 = new Stack<int>();
        }
        public void EnQueue(int x)
        {

            Stack<int> stack2 = new Stack<int>();
            foreach (int item in stack1)
            {
                stack2.Push(item);
            }
            stack2.Push(x);
            stack1 = new Stack<int>();
            foreach (int item in stack2)
            {
                stack1.Push(item);
            }
        }

        public int DeQueue()
        {
            int value = stack1.Pop();
            return value;
        }

        public void ShowQueue()
        {
            foreach (int item in stack1)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class MyStack
    {
        Queue<int> myqueue1;
        public MyStack()
        {
            myqueue1 = new Queue<int>();
        }

        public void Push(int x)
        {
            Queue<int> myqueue2 = new Queue<int>();
            myqueue2.Enqueue(x);
            foreach (int item in myqueue1)
            {
                myqueue2.Enqueue(item);
            }
            myqueue1 = new Queue<int>();
            foreach (int item in myqueue2)
            {
                myqueue1.Enqueue(item);
            }
        }

        public int Pop()
        {
            int value = myqueue1.Dequeue();
            return value;
        }

        public void ShowStack()
        {
            foreach (int item in myqueue1)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

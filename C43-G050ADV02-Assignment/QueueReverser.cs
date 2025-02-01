using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class QueueReverser<T>
    {
        public void ReverseQ(Queue<T> queue)
        {
            if (queue == null || queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty or null.");
            }

            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        public Queue<T> ReverseFirstK(Queue<T> queue, int k)
        {
            if (queue == null || queue.Count == 0 || k <= 0 || k > queue.Count)
            {
                throw new ArgumentException("Invalid input: Queue is empty, or K is out of range.");
            }

            Stack<T> stack = new Stack<T>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            for (int i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class StackSearch<T> where T : IComparable<T>
    {
        private Stack<T> stack;

        public StackSearch()
        {
            stack = new Stack<T>();
        }

        public void PushItems(params T[] items)
        {
            foreach (var item in items)
            {
                stack.Push(item);
            }
        }

        public void SearchTarget(T target)
        {
            int count = 0;
            bool found = false;

            Stack<T> tempStack = new Stack<T>();

            while (stack.Count > 0)
            {
                count++;
                T item = stack.Pop();
                tempStack.Push(item);

                if (item.CompareTo(target) == 0)
                {
                    found = true;
                    break;
                }
            }

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

            if (found)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }

        public void PrintStack()
        {
            Console.WriteLine("Stack Contents:");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

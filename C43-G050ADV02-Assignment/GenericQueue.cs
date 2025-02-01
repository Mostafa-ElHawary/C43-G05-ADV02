using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    public class GenericQueue : IEnumerable
    {
        private Queue<object> queue;

        public GenericQueue()
        {
            queue = new Queue<object>();
        }
        public void Enqueue(object item)
        {
            queue.Enqueue(item);
        }


        public object Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return queue.Dequeue();
        }
        public IEnumerator GetEnumerator()
        {
            return queue.GetEnumerator();
        }
    }
}

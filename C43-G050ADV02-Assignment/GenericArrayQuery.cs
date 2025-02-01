using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    public class ArrayQ<T> where T : IComparable<T>
    {
        private T[] array;
        public ArrayQ(T[] array)
        {
            this.array = array;
        }

        public int CountGreater(T x)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.CompareTo(x) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }

}

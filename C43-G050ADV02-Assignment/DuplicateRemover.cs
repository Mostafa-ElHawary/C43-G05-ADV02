using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class DuplicateRemover<T>
    {
        public T[] RemoveDuplicates(T[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array is null or empty.");
            }

            HashSet<T> uniqueSet = new HashSet<T>(array);
            T[] result = uniqueSet.ToArray();

            return result;
        }

    }
}

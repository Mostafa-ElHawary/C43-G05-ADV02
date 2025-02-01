using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class ArrayIntersectionFinder<T>
    {
        public List<T> FindIntersection(T[] array1, T[] array2)
        {
            Dictionary<T, int> elementCounts = new Dictionary<T, int>();
            foreach (T element in array2)
            {
                if (elementCounts.ContainsKey(element))
                {
                    elementCounts[element]++;
                }
                else
                {
                    elementCounts[element] = 1;
                }
            }

            List<T> result = new List<T>();
            foreach (T element in array1)
            {
                if (elementCounts.TryGetValue(element, out int count) && count > 0)
                {
                    result.Add(element);
                    elementCounts[element]--; 
                }
            }

            return result;
        }
    }
}

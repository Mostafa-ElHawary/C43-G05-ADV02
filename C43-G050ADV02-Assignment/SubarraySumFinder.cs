using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class SubarraySumFinder<T> where T : struct
    {
        public List<T> FindSublist(List<T> list, T targetSum)
        {
            if (list == null || list.Count == 0)
            {
                return null;
            }

            dynamic currentSum = default(T);
            int start = 0;

            for (int end = 0; end < list.Count; end++)
            {
                currentSum += (dynamic)list[end];

                while (currentSum > (dynamic)targetSum && start <= end)
                {
                    currentSum -= (dynamic)list[start];
                    start++;
                }

                if (currentSum == (dynamic)targetSum)
                {
                    return list.GetRange(start, end - start + 1);
                }
            }

            return null;
        }
    }
}

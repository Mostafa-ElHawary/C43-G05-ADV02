using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    public class PalindromeChecker<T>
    {
        private T[] array;

        public PalindromeChecker(T[] array)
        {
            this.array = array;
        }

        public bool IsPalindrome()
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                if (!array[left].Equals(array[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}

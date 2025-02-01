using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class OddNumberRemover<T>
    {
        public List<T> RemoveOddNumbers(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List is null or empty.");
            }

            List<T> evenList = new List<T>();

            foreach (var item in list)
            {
                if (Helper.IsEven(item))
                {
                    evenList.Add(item);
                }
            }

            return evenList;
        }

    }
}

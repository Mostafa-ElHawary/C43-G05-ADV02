using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class Helper
    {
        public static void PrintArr<T>(Queue<T> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArr<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArr<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static bool IsEven<T>(T number)
        {
            dynamic num = number;
            return num % 2 == 0;
        }

        public static void PrintGenericQueue(GenericQueue queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

       
    }
}

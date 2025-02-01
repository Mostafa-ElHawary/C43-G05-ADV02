namespace C43_G050ADV02_Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1

            //int[] array = { 11, 5, 3 };
            //int[] queries = { 1, 5, 13 };
            //ArrayQ<int> arrayQuery = new ArrayQ<int>(array);

            //foreach (var query in queries)
            //{
            //    int result = arrayQuery.CountGreater(query);
            //    Console.WriteLine(result);
            //}

            #endregion

            #region Q2

            //int[] array = { 1, 3, 2, 4, 1 };

            //PalindromeChecker<int> checker = new PalindromeChecker<int>(array);

            //if (checker.IsPalindrome())
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Q3

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine("Original Queue:");
            //Helper.PrintArr<int>(queue);


            //QueueReverser<int> reverser = new QueueReverser<int>();

            //reverser.ReverseQ(queue);

            //Console.WriteLine("Reversed Queue:");
            //Helper.PrintArr<int>(queue);

            #endregion

            #region Q4

            //string input = "[(}]{}";

            //BalancedParenthesesChecker<char> checker = new BalancedParenthesesChecker<char>();
            //if (checker.IsBalanced(input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}

            #endregion

            #region Q5

            //int[] array = { 1, 2, 3, 2, 4, 3, 5 };

            //Console.WriteLine("Original Array:");
            //Helper.PrintArr<int>(array);

            //DuplicateRemover<int> remover = new DuplicateRemover<int>();

            //int[] uniqueArray = remover.RemoveDuplicates(array);

            //Console.WriteLine("Array After Removing Duplicates:");
            //Helper.PrintArr<int>(uniqueArray);

            #endregion

            #region Q6

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Original List:");
            //Helper.PrintArr<int>(list);

            //OddNumberRemover<int> remover = new OddNumberRemover<int>();

            //List<int> evenList = remover.RemoveOddNumbers(list);

            //Console.WriteLine("List After Removing Odd Numbers:");
            //Helper.PrintArr<int>(evenList);

            #endregion

            #region Q7

            //GenericQueue queue = new GenericQueue();

            //queue.Enqueue(1);         
            //queue.Enqueue("Apple");   
            //queue.Enqueue(5.28);

            //Helper.PrintGenericQueue(queue);

            //Console.WriteLine("\nDequeued Item: " + queue.Dequeue());

            //Helper.PrintGenericQueue(queue);

            #endregion

            #region Q8

            //StackSearch<int> stackSearch = new StackSearch<int>();

            //stackSearch.PushItems(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);

            //stackSearch.PrintStack();

            //Console.Write("Enter the target integer to search: ");
            //int target = int.Parse(Console.ReadLine());

            //stackSearch.SearchTarget(target);

            #endregion

            #region Q9

            //int[] array1 = { 1, 2, 3, 4, 4, 10 };
            //int[] array2 = { 10, 4, 4 };

            //ArrayIntersectionFinder<int> finder = new ArrayIntersectionFinder<int>();
            //List<int> intersection = finder.FindIntersection(array1, array2);

            //Console.WriteLine("[" + string.Join(",", intersection) + "]");

            #endregion

            #region Q10

            //List<int> inputList = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;

            //SubarraySumFinder<int> finder = new SubarraySumFinder<int>();
            //List<int> sublist = finder.FindSublist(inputList, target);

            //if (sublist != null)
            //{
            //    Console.WriteLine("[" + string.Join(", ", sublist) + "]");
            //}
            //else
            //{
            //    Console.WriteLine("No sublist found.");
            //}
            #endregion

            #region Q11

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            int k = 3;

            Console.WriteLine("Original Queue:");
            PrintQueue(queue);

            QueueReverser<int> reverser = new QueueReverser<int>();

            Queue<int> reversedQueue = reverser.ReverseFirstK(queue, k);

            Console.WriteLine("Queue After Reversing First " + k + " Elements:");
            PrintQueue(reversedQueue);
        }

        static void PrintQueue<T>(Queue<T> queue)
        {
            Console.WriteLine("[" + string.Join(", ", queue) + "]");
        }
        #endregion
    }
    
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G050ADV02_Assignment
{
    internal class BalancedParenthesesChecker<T>
    {
        public bool IsBalanced(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in input)
            {
                if (parenthesesMap.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (parenthesesMap.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Peek() != parenthesesMap[c])
                    {
                        return false;
                    }
                    stack.Pop(); 
                }
            }

            return stack.Count == 0;
        }
    }
}

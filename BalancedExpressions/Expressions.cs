using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalancedExpressions
{
    class Expressions
    {
        private char[] leftBrackets = { '(', '<', '{', '['};
        private char[] rightBrackets = { ')', '>', '}', ']'};
        public bool isBalanced(string input) {
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                if (leftBrackets.Contains(ch))
                    stack.Push(ch);
                if (rightBrackets.Contains(ch))
                {
                    if (stack.Count == 0)
                        return false;
                    var top = stack.Pop();
                    if (Array.IndexOf(rightBrackets, ch) != Array.IndexOf(leftBrackets, top))
                        return false;
                }
                    
            }
            return stack.Count==0;
        }
    }
}

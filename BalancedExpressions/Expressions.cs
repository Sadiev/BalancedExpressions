using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedExpressions
{
    class Expressions
    {
        public bool isBalanced(string input) {
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                if (ch == '(')
                    stack.Push(ch);
                if (ch == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    stack.Pop();
                }
                    
            }
            return stack.Count==0;
        }
    }
}

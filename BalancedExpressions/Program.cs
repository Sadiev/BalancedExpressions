using System;

namespace BalancedExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "<1+2>{}";
            var result = new Expressions().isBalanced(str);
            Console.WriteLine(result);
        }
    }
}

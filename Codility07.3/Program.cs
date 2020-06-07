/*
A string S consisting of N characters is called properly nested if:

S is empty;
S has the form "(U)" where U is a properly nested string;
S has the form "VW" where V and W are properly nested strings.
For example, string "(()(())())" is properly nested but string "())" isn't.

Write a function:

class Solution { public int solution(String S); }

that, given a string S consisting of N characters, returns 1 if string S is properly nested and 0 otherwise.

For example, given S = "(()(())())", the function should return 1 and given S = "())", the function should return 0, as explained above.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..1,000,000];
string S consists only of the characters "(" and/or ")".
*/

using System;
using System.Collections.Generic;

namespace Codility07._3
{
    class Solution
    {
        public int solution(string S)
        {
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < S.Length; i++)
                if (S[i] == '(')
                    brackets.Push(S[i]);
                else
                {
                    if (brackets.Count == 0)
                        return 0;
                    char top = brackets.Peek();
                    if (top == '(')
                        brackets.Pop();
                    else
                        return 0;
                }
            if (brackets.Count > 0)
                return 0;
            return 1;
        }
    }

    class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            string S = "(()(())())";
            //string S = "())";
            int s = sol.solution(S);
            Console.WriteLine("Solution: " + s);
            //Console.WriteLine("Solution: " + string.Join(", ", s));
        }
    }
}

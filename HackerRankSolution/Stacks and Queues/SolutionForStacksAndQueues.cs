using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankSolution.Stacks_and_Queues
{
    public class SolutionForStacksAndQueues
    {
        private static readonly List<char> LeftBrackets = new List<char> { '{', '(', '[' };
        private static readonly List<char> RightBrackets = new List<char> { '}', ')', ']' };
        public static string IsBalanced(string s)
        {
            var stack = new Stack<char>();
            var brackets = s.ToCharArray();

            foreach (var bracket in brackets)
            {
                if (IsLeftBracket(bracket))
                    stack.Push(bracket);

                if (IsRightBracket(bracket))
                {
                    if (stack.Count == 0)
                        return "No";

                    var top = stack.Pop();

                    if (BracketsMatch(bracket, top))
                        return "No";
                }
            }

            return stack.Count == 0 ? "Yes" : "No";
        }

        private static bool IsLeftBracket(char left)
        {
            return LeftBrackets.Contains(left);
        }

        private static bool IsRightBracket(char right)
        {
            return RightBrackets.Contains(right);
        }

        private static bool BracketsMatch(char left, char right)
        {
            return LeftBrackets.IndexOf(left) == RightBrackets.IndexOf(right);
        }
    }
}

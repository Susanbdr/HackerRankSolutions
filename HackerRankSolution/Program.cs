using System;
using HackerRankSolution.Stacks_and_Queues;

namespace HackerRankSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = BalancedBrackets.IsBalanced(s);

                Console.WriteLine(result);
            }

        }
    }
}

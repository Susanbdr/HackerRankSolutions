using System;
using HackerRankSolution.Stacks_and_Queues;

namespace HackerRankSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = Convert.ToInt32(Console.ReadLine());
            var queue = new QueuesATaleOfTwoStacks();
            for (var i = 1; i <= item; i++)
            {
                var input = Console.ReadLine()?.Split(' ');
                
                if(Convert.ToInt32(input[0]) == 1)
                    queue.Enqueue(Convert.ToInt32(input[1]));

                if (Convert.ToInt32(input[0]) == 2)
                    queue.Dequeue();

                if (Convert.ToInt32(input[0]) == 3)
                    queue.Peek();
            }
        }
    }
}

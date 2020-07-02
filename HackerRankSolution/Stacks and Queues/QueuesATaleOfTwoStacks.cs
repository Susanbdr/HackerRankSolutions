using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankSolution.Stacks_and_Queues
{
    public class QueuesATaleOfTwoStacks
    {
        private readonly Stack<int> _stackOne = new Stack<int>();
        private readonly Stack<int> _stackTwo = new Stack<int>();

        public void Enqueue(int item)
        {
            _stackOne.Push(item);
        }

        public int Dequeue()
        {
            Copy();
            return _stackTwo.Pop();
        }

        public int Peek()
        {
            Copy();
            return _stackTwo.Peek();
        }

        public void Copy()
        {
            if(_stackTwo.Count == 0)
                while(_stackOne.Count > 0)
                    _stackTwo.Push(_stackOne.Pop());
        }

        public void Print()
        {
            foreach (var item in _stackOne)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System.Collections.Generic;

namespace HelloCsharp
{
    public class StackQueue
    {
        private Stack<int> _stackOne = new Stack<int>();
        private Stack<int> _stackTwo = new Stack<int>();

        public void Enqueue(int item)
        {
            _stackOne.Push(item);
        }

        public int Dequeue()
        {
            int item = 0;
            
            while (_stackOne.Count >= 1)
            {
                if (_stackOne.Count == 1)
                {
                    item = _stackOne.Pop();
                    continue;                    
                }
                
                _stackTwo.Push(_stackOne.Pop());
            }

            while (_stackTwo.Count > 0)
            {
                _stackOne.Push(_stackTwo.Pop());
            }

            return item;
        }
    }
}
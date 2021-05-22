using System;

namespace HelloCsharp
{
    public class Stack
    {
        private int _count = 0;
        private int[] _array = new int[5];

        public int Count => _count;

        public void Push(int item)
        {
            if (_count < _array.Length)
            {
                _array[_count++] = item;
                return;
            }
            
            var temporaryArr = _array;
            _array = new int[2 * _count];

            for (int i = 0; i < temporaryArr.Length; i++)
            {
                _array[i] = temporaryArr[i];
            }

            _array[_count++] = item;
        }

        public int Pop()
        {
            if (_count == 0)
                throw new IndexOutOfRangeException();

            return _array[--_count];
        }

        public int Peek()
        {
            if (_count == 0)
                throw new IndexOutOfRangeException();

            return _array[_count - 1];
        }

        public bool isEmpty()
        {
            return _count == 0;
        }
    }
}
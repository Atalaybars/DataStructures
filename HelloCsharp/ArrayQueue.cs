namespace HelloCsharp
{
    public class ArrayQueue
    {
        private int _f = 0;
        private int _r = 0;

        private int[] _array = new int[5];

        public void Enqueue(int item)
        {
            _array[_r++] = item;
        }

        public int Dequeue()
        {
            return _array[_f++];
        }

        public int Peek => _array[_r - 1];
    }
}
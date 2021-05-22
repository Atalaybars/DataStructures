namespace HelloCsharp
{
    public class Array
    {
        private int[] array;
        public int count { get; set; } = 0;
        public Array(int length)
        {
            array = new int[length];
        }

        public void Insert(int item)
        {
            if (!(count == array.Length))
            {
                array[count++] = item;
                return;
            }
                
            var temporaryArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                temporaryArray[i] = array[i];
            }

            temporaryArray[count] = item;

            array = temporaryArray;

            count = array.Length;
        }

        public void RemoveAt(int index)
        {
            if (array.Length <= index || index <= -1)
                return;
                
            var temporaryArray = new int[array.Length - 1];

            int j = 0;
                
            for (var i = 0; i < temporaryArray.Length; i++)
            {
                if (i == index)
                    j++;
                    
                temporaryArray[i] = array[j++];
            }

            array = temporaryArray;
            count = array.Length;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                    return i;
            }

            return -1;
        }
    }
}
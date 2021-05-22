namespace HelloCsharp
{
    public class Tree
    {
        // Binary Trees are the eighth wonder of the world

        public Tree(int value)
        {
            _root = new Node(value);
        }
        
        private class Node
        {
            public int _value;
            public Node? _leftChild;
            public Node? _rightChild;

            public Node(int value)
            {
                _value = value;
            }
        }

        private Node? _root;

        public void Insert(int value)
        {
            var currentNode = _root;

            while (true)
            {
                if (currentNode._value > value)
                {
                    if (currentNode._leftChild == null)
                    {
                        currentNode._leftChild = new Node(value);
                        break;
                    }

                    currentNode = currentNode._leftChild;
                    continue;
                }

                if (currentNode._rightChild == null)
                {
                    currentNode._rightChild = new Node(value);
                    break;
                }

                currentNode = currentNode._rightChild;   
            }
        }
        
        public bool Find(int value)
        {
            var currentNode = _root;

            while (currentNode != null)
            {
                if (currentNode._value > value)
                {
                    currentNode = currentNode._leftChild;
                    continue;
                }

                if (currentNode._value < value)
                {
                    currentNode = currentNode._rightChild;
                    continue;                    
                }

                return true;
            }

            return false;
        }
    }
}
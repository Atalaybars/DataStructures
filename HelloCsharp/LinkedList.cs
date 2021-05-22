namespace HelloCsharp
{
    public class LinkedList
    {
        private class Node
        {
            public int? Value;
            public Node? Next;

            public Node(int item)
            {
                Value = item;
            }
        }

        private int Size = 0;
        private Node? First;
        private Node? Last;

        public void AddLast(int item)
        {
            var node = new Node(item);
            
            if (IsEmpty())
            {
                First = node;
                Last = node;
                Size++;
                return;
            }

            Last.Next = node;
            Last = node;

            Size++;
        }
        
        public void RemoveLast()
        {
            if (IsEmpty())
                return; // No Such Element exception goes here

            if (First == Last)
            {
                First = Last = null;
                Size--;
                return;
            }
            
            var previous = getPrevious(Last, First);
            
            previous.Next = null; 
            Last = previous;
            
            Size--;
        }

        private Node getPrevious(Node lastNode, Node current)
        {
            if (current.Next == lastNode) return current;

            return getPrevious(lastNode, current.Next);
        }
        
        /*
        public int countNodes(Node first)
        {
            var count = 1; 
                
            if (first.Next == null) return count;

            count += countNodes(first.Next);

            return count;
        }
        
        note:
        LinkedLists are AMAZING!
        They blew my mind. There's lots of cool stuff here. 
        */

        public void RemoveFirst()
        {
            Node newFirstNode;

            if (First == Last)
            {
                First = Last = null;
                Size--;
            }
                
            if (First == null)
            {
                // throw new No Such Element error's C# version
                return;
            }
            
            newFirstNode = First.Next;

            First.Next = null;
            First = newFirstNode;
            
            Size--;
        }
        
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;

            /*
            var node = First;

            while (node != null)
            {
                if (node.Value == item)
                    return true;
                
                node = node.Next;
            }

            return false;
            */
        }
        public int IndexOf(int item)
        {
            var node = First;
            var index = 0;

            while (node != null)
            {
                if (node.Value == item)
                    return index;
                
                index++;
                node = node.Next;
            }

            return -1;
        }

        private bool IsEmpty () => First == null;

        public void AddFirst(int item)
        {
            var node = new Node(item);
            
            if (IsEmpty())
            {
                First = node;
                Last = node;
                Size++;
                return;
            }

            node.Next = First;
            First = node;
            
            Size++;
        }

        public int GetSize => Size;
        
        public void DoUpSideDown()
        {
            if (IsEmpty()) return;

            if (First == Last) return;

            var nodes = ToArray();

            Node node = null;
            
            for (int i = nodes.Length - 1; i >= 0 ; i--)
            {
                if (i == 0) break;
                nodes[i].Next = nodes[i - 1];
            }

            First.Next = null;
            var formerFirst = First;
            First = Last;
            Last = formerFirst;
        }

        private Node[] ToArray()
        {
            var nodes = new Node[Size];

            var node = First;
            
            for (int i = 0; i < Size; i++)
            {
                nodes[i] = node;
                node = node.Next;
            }

            return nodes;
        }
    }
}
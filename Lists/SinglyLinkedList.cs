using System;


namespace Lists
{
    public class SinglyLinkedList : List
    {
        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode(object e, LinkedNode next)
            {
                this.e = e;
                this.next = next;
                
            }
        }
        private int SIZE;
        private LinkedNode first = new LinkedNode(null, null);

        private LinkedNode nodeAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }

        public void add(int index, object e)
        {
            if (index <= SIZE)
            {
                LinkedNode node = nodeAt(index - 1);
                Console.WriteLine(node.e);
                node.next = new LinkedNode(e, node.next);
                SIZE++;
            }
            else
                throw new System.IndexOutOfRangeException();
        }

        public void add(object e)
        {
            add(SIZE, e);
        }
        public int indexOf(object e)
        {
            LinkedNode node = first.next;
            for (int i = 0; i < SIZE; i++)
            {
                if (node.e.Equals(e))
                    return i;
                node = node.next;
            }
            return -1;
        }
        private void removeAfter(LinkedNode node)
        {
            if (node.next != null)
            {
                node.next = node.next.next;
                SIZE--;
            }
        }

        public void remove(int index)
        {
            LinkedNode node = nodeAt(index - 1);
            removeAfter(node);
        }

        public void remove(object e)
        {
            /*  int i = indexOf(e);
              if (i > -1)
                  remove(i);*/
            LinkedNode node = first;
            while (node.next != null &&
                   !node.next.e.Equals(e))
                node = node.next;
            removeAfter(node);
        }

        public void set(int index, object e)
        {
            nodeAt(index).e = e;
        }

        public int size()
        {
            return SIZE;
        }
        public bool isEmpty()
        {
            return SIZE == 0;
            //return first.next == null;
        }
        public bool contains(object e)
        {
            return indexOf(e) > -1;
        }
        public object get(int index)
        {
            return nodeAt(index).e;
        }
    }
}

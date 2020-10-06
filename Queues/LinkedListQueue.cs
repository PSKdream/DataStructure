using System;
using Lists;

namespace Queues
{
    public class LinkedListQueue : Queue
    {
        private List list = new LinkedList();

        public bool isEmpty() 
        { 
            return list.isEmpty(); 
        }
        public int size() 
        { 
            return list.size(); 
        }
        public void enqueue(object e)
        {
            list.add(e);
        }

        public object dequeue()
        {
            object e = peek();
            list.remove(0);
            return e;
        }
        public object peek()
        {
            if (isEmpty())
                throw new System.MissingMemberException();
            return list.get(0);
        }

    }

}

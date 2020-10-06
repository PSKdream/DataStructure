using System;
using Lists;

namespace Queues
{
    public class ArrayListQueue : Queue
    {
        private List list;
        public ArrayListQueue(int cap)
        { 
            list = new ArrayList(cap); 
        }
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

        }
        public object peek() 
        {
            return list.get(list.size() - 1);
        }
    }

}

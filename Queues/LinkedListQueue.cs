using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists;

namespace Queues
{
    public class LinkedListQueue : Queue
    {
        private List list = new LinkedList();
        public bool isEmpty() { return list.isEmpty(); }
        public int size() { return list.size(); }
        public void enqueue(object e) { }
        public object dequeue() { 
        }
        public object peek() { }
    }

}

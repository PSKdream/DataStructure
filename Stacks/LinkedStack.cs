using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class LinkedStack : Stack
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
        private LinkedNode first;

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            return first.e;
        }

        public object pop()
        {
            object e = first.e;
            first = first.next;
            SIZE--;
            return e;
        }

        public void push(object e)
        {
            first = new LinkedNode(e, first);
            SIZE++;
        }

        public int size()
        {
            return SIZE;
        }
    }
}

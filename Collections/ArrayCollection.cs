using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayCollection : Collection
    {
        private int SIZE;
        private object[] data;
        private int cap; //capacity

        public ArrayCollection(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        public void add(object e)
        {
            ensureCapacity();
            data[SIZE++] = e;
        }
        private void ensureCapacity()
        {
            if(SIZE+1 > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for(int i=0; i<SIZE; i++)
                {
                    tempdata[i] = data[i];
                }
                data = tempdata;
            }
            else if (data.Length > cap && data.Length > 2 * SIZE)
            { 
                object[] tempdata = new object[data.Length / 2 + 1];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
                data = tempdata;
            }
        }
        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }

        private int indexOf(object e)
        {
            for (int i = 0; i < SIZE; i++)
                if (e.Equals(data[i]))
                    return i;
            return -1;
        }
        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(object e)
        {
            int i = indexOf(e);
            if(i != -1)
            {
                data[i] = data[--SIZE];
                data[SIZE] = null;
            }            
        }
        public int size()
        {
            return SIZE;
        }
    }
}

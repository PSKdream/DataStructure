using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class ArrayList : List
    {
        private object[] data;
        private int cap;
        private int SIZE;
        public ArrayList(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length) //3 3
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
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
        public void add(int index, object e)
        {
            ensureCapacity();
            for(int i = SIZE; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = e;
            SIZE++;
        }

        public void add(object e)
        {
            add(SIZE, e);
        }
        public void remove(int index)
        {
            if (index >= SIZE) return;
            for(int i=index+1; i<SIZE; i++)
            {
                data[i - 1] = data[i];
            }
            data[--SIZE]= null;
        }

        public void remove(object e)
        {
            int i = indexOf(e);
            if(i > -1)
                remove(i);
        }
        public object get(int index)
        {
            return data[index];
        }
        public void set(int index, object e)
        {
            data[index] = e;
        }
        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }
        public int indexOf(object e)
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

        public int size()
        {
            return SIZE;
        }
    }
}

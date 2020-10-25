using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeaps
{
    public class BinaryHeap : PriorityQueue
    {
        protected object[] data;
        protected int SIZE;
        protected int cap;

        public BinaryHeap(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }


        public object dequeue()
        {
            object max = peek();
            data[0] = data[--SIZE];
            data[SIZE] = null;
            if (SIZE > 1) reorderDown(0);
            return max;
        }

        public void enqueue(object e)
        {
            ensureCapacity();
            data[SIZE] = e;
            reorderUp(SIZE++);
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            return data[0];
        }

        public int size()
        {
            return SIZE;
        }
        protected virtual void reorderDown(int k) 
        {
            int c;
            while ((c = 2 * k + 1) < SIZE)
            {
                if (c + 1 < SIZE && isGreaterThan(c + 1, c))
                    c++;
                if (!isGreaterThan(c, k)) break;
                swap(k, c);
                k = c;
            }

        }

        protected virtual void reorderUp(int k) 
        {
            while (k > 0)
            {
                int p = (k - 1) / 2;
                if (!isGreaterThan(k, p))
                    break;
                swap(k, p);
                k = p;
            }
        }

        protected void swap(int i, int j) 
        {
            object temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }

        private bool isGreaterThan(int i, int j) 
        {
            return ((IComparable)data[i]).CompareTo(data[j]) > 0;
        }

        private void ensureCapacity() 
        {
            object[] tempdata;
            if (SIZE + 1 > data.Length)
                //Increase Capacity             
                tempdata = new object[2 * data.Length + 1];
            else if (data.Length > cap && data.Length > 2 * SIZE)
                //Decrease Capacity
                tempdata = new object[data.Length / 2 + 1];
            else return;
            for (int i = 0; i < SIZE; i++)
                tempdata[i] = data[i];
            data = tempdata;
        }

        public static void heapSort(object[] x)
        {
            BinaryHeap h = new BinaryHeap(x.Length);
            h.data = x;
            h.SIZE = x.Length;
            for (int k = h.size() - 1; k >= 0; k--)
                h.reorderDown(k);
            for (int k = h.size() - 1; k > 0; k--)
                x[k] = h.dequeue();
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeaps
{
    public class BinaryMinHeap : BinaryHeap
    {
        public BinaryMinHeap(int cap) : base(cap)
        {
        }
        protected override void reorderDown(int k)
        {
            int c;
            while ((c = 2 * k + 1) < SIZE)
            {
                if (c + 1 < SIZE && isLesserThan(c + 1, c))
                    c++;
                if (!isLesserThan(c, k)) break;
                swap(k, c);
                k = c;
            }

        }
        protected override void reorderUp(int k)
        {
            while (k > 0)
            {
                int p = (k - 1) / 2;
                if (!isLesserThan(k, p))
                    break;
                swap(k, p);
                k = p;
            }
        }

        private bool isLesserThan(int i, int j)
        {
            return ((IComparable)data[i]).CompareTo(data[j]) < 0;
        }

        public static void heapSortDsc(object[] x)
        {
            BinaryMinHeap h = new BinaryMinHeap(x.Length);
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

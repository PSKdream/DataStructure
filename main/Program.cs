using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue data = new LinkedListPriority();
            data.enqueue(2);
            data.enqueue(2);
            data.enqueue(5);
            Console.WriteLine(data.peek());
            data.enqueue(2);
            data.enqueue(10);
            data.enqueue(2);
            Console.WriteLine(data.peek());
            data.dequeue();
            data.dequeue();
        }
    }
}

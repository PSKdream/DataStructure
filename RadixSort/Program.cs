using Queues;
using Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = { 625,-12.3,25, 25.22 ,23.2,10.2,5.557,500.2, 7.7 };
            int multiply = 0;
            //หาว่ามีลบไหม
            Double min = Double.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                    min = input[i];
            }
            Console.WriteLine(min);
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] - min;
            }
            Console.WriteLine("---------------");
            for (int i = 0; i < input.Length; i++)
            {

                Console.WriteLine(input[i]);
            }
            Console.WriteLine("---------------1");

            //หาจำนวนทดสนิยม
            for (int i = 0; i < input.Length; i++)
            {
                int k = 0;
                double num1 = input[i];
                while (num1 != (int)num1)
                {
                    Console.WriteLine(num1 +" " + (int)num1);
                    num1 = num1 * 10;
                    k++;
                }
                if (k > multiply)
                    multiply = k;
            }
            Console.WriteLine("---------------2");
            //int[] num = { 10, 123, 143, 183, 14, 55,1,25,39,68 ,2500,111};
            int[] num = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                num[i] = (int)(input[i] * (int)Math.Pow(10, multiply));
            }

            //หาว่ามีกี่ตำแหน่ง
            int max = Int32.MinValue;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                    max = num[i];
            }
            int loop = (int)Math.Log10((double)max)+1;

            Console.WriteLine("---------------"+loop);
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine(num[i]);
            }
            Console.WriteLine("---------------");

            //Radix sort
            object[] q = new object[10];
            for (int i = 0; i < 10; i++)
            {
                q[i] = new ArrayQueue(num.Length);
            }

            for (int i = 0; i <num.Length; i++)
             {
                //int number = (int) num.dequeue();
                //Console.WriteLine("n :"+number);
                int position = num[i] / (int)Math.Pow(10,0) % 10;
                //Console.WriteLine("p :" + position);
                ((ArrayQueue)q[position]).enqueue(num[i]);
             }
            for (int k = 1; k <= loop; k++)
            {
                for (int i = 0; i < 10; i++)
                {
                    ArrayQueue queue = ((ArrayQueue)q[i]);
                    int s = queue.size();
                    for (int j = 0; j < s; j++)
                    {
                        int number = (int)queue.dequeue();
                        int position = number / (int)Math.Pow(10, k) % 10;
                        ((ArrayQueue)q[position]).enqueue(number);
                    }
                }
            }
            //แสดงผล
            for (int i = 0; i < 10; i++)
            {
                ArrayQueue queue = ((ArrayQueue)q[i]);
                while (queue.size() != 0)
                    Console.WriteLine( ((int)queue.dequeue()/Math.Pow(10,multiply)) + (min));
            }
            
        }
    }
}

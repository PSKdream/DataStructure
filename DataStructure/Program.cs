using System;
using Stacks;
using System.Collections;

namespace DataStructure
{
    class Program
    {
        static bool IsCorrectParentheses(string t)
        {
            string begin = "{([", end = "})]";
            ArrayStack stack = new ArrayStack(t.Length);

            for (int i = 0; i < t.Length; i++)
            {
                if (begin.IndexOf(t[i].ToString()) >= 0)
                    stack.push(t[i]);
                else
                {
                    int j = end.IndexOf(t[i].ToString());
                    if (j >= 0)
                    {
                        if (stack.isEmpty() || !stack.pop().Equals(begin[j]))
                            return false;
                    }
                }
            }
            return stack.isEmpty();
        }

        static int Lv(char i ,bool sw =false)
        {
            string operators = "+-*/^()";
            int[] lv = { 2, 2, 3, 3, 5, 6, 1 };
            int[] lvsw = { 2, 2, 3, 3, 4, 0 };
            if (sw)
                return lvsw[operators.IndexOf(i)];
            return lv[operators.IndexOf(i)];
        }
       static bool IsOperator(char c)
        {
            string Operator = "(^*/+-)";
            return Operator.IndexOf(c) >= 0;
        }
        static string InfixToPostfix(string text)
        {
            string text1 = "";

            ArrayStack data = new ArrayStack(text.Length);
            if (IsCorrectParentheses(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char token = text[i];
                    if (IsOperator(token))
                    {
                        int p = Lv(token);
                        while (!data.isEmpty() && Lv((char)data.peek(), true) >= p)
                        {
                            text1 += data.pop();
                        }
                        if (token.Equals(')'))
                            data.pop();
                        else
                            data.push(token);
                    }
                    else
                    {
                        text1 += text[i];
                    }
                }

            }
            while(!data.isEmpty())
                text1 += data.pop();
            return text1;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); ;
            string post = InfixToPostfix(text);
            Console.WriteLine(post);
            Stacks.Stack data = new ArrayStack(post.Length);
            for(int i=0; i < post.Length; i++)
            {
               
                char token = post[i];
                if (!IsOperator(token))
                {
               //     Console.WriteLine(token);
                    data.push(int.Parse(token.ToString()));
                }
                else
                {
                    int last = (int)data.pop();
                    int first = (int)data.pop();
                    switch (token)
                    {
                        case '+':
                         //   Console.WriteLine("1-");
                            data.push(first + last); break;
                        case '-':
                         //   Console.WriteLine("2-");
                            data.push((first - last)); break;
                        case '*':
                           // Console.WriteLine("3-");
                            //Console.WriteLine(first);
                            data.push((first * last)); break;
                        case '/':
                           // Console.WriteLine("4-");
                            data.push((first / last)); break;
                        case '^':
                         //   Console.WriteLine("5-");
                            data.push((first ^ last)); break;
                    }
                }
            }
            Console.WriteLine(Convert.ToInt32(data.peek()));
        }
    }
}

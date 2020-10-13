using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacks;

namespace DataStructure
{
    class cal
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

        static void main()
        {
            String text = "(1+2)/2";
            if (IsCorrectParentheses(text))
            {
                Console.WriteLine(1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Stack<int> stack = new Stack<int>();
           mystack mystack = new mystack();
            for (int i = 0; i < 10; i++)
            {
            stack.Push(1);

            }
            for (int i = 0; i < 9; i++)
            {

            WriteLine(stack.Pop());
            }
            Stack<String> stack2 = new Stack<String>();
            stack2.Push("A");
            stack2.Push("B");
            stack2.Push("C");
            stack2.Push("D");
            WriteLine(stack2.Count());
            WriteLine(stack2.Peek());
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i;
            ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter your age");
            x=int.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine("your age is " + x);
            Console.WriteLine("your name is {0}.",x);
            Console.WriteLine(@"your age is{x} ");
            Console.ReadKey();
           

           





        }
    }
}

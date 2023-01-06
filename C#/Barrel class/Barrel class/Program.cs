using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrel_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mybarrelclass b=new mybarrelclass(100);
            b.fill(10);
            Console.WriteLine(b);

            b.drain(10);
            Console.WriteLine();
        }
    }
}

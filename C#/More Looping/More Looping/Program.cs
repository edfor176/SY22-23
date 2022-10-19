using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace More_Looping
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            WriteLine("choose a number in order to see the table");
            int num = int.Parse(ReadLine());
            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j <= i; j++)

                {

                    Write(i);
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}

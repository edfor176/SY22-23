using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace looping
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // This is the assignment
            //NUMBER #1
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 30; j++)

                {

                    Write(i);
                }
                WriteLine();
            }
            ReadKey();
            //NUMBER #2
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)

                {

                    Write(i);
                }
                WriteLine();
            }
            ReadKey();
            //NUMBER #3
            for (int i = 0; i < 5; i++)
            {


                for (int t = 0; t < 5 - i; t++)
                {
                    Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {

                    Write("*");
                }

                WriteLine();
            }
            // NUMBER #4
            for (int i = 0; i < 5; i++)
            {


                for (int t = 0; t < 5 - i; t++)
                {
                    Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {

                    Write("*");
                }
                for (int j = 0; j < i; j++)
                {

                    Write("*");
                }
                WriteLine();
            }
            //NUMBER #5
            for (int i = 1; i < 6; i++)
            {


                for (int t = 0; t < 5 - i; t++)
                {
                    Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {

                    Write(i);
                }
                for (int j = 1; j < i; j++)
                {

                    Write(i);
                }
                WriteLine();
            }
            //NUMBER #6
            for (int i = 1; i < 6; i++)
            {


                for (int t = 0; t < 5 - i; t++)
                {
                    Write(" ");
                }

                for (int j = 0; j < i; j++)
                {

                    Write(i - j);
                }
                for (int j = 2; j <= i; j++)
                {

                    Write(j);
                }
                WriteLine();
            }
            WriteLine();
            ReadKey();
            }



        }
    }



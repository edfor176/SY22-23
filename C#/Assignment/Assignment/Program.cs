using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
           
          

            correct = correct + 1;
            Console.WriteLine("How many times days can Elijah sleep in mr Clarkes class in a week");
            Console.WriteLine("A. Everyday");
            Console.WriteLine("B. 2");
            Console.WriteLine("C. none");
            Console.WriteLine("D. 3");
          string answer = Console.ReadLine();
            if (answer == "A")
                Console.WriteLine("whats 4 times 4");
            Console.WriteLine("A. 16");
            Console.WriteLine("B. 2");
            Console.WriteLine("C. 0");
            Console.WriteLine("D. 3");
              answer = Console.ReadLine(); 
               if (answer == "A")
            Console.WriteLine("Are you exuasted");
            Console.WriteLine("A. No I dont get tired");
            Console.WriteLine("B. Yes");
            Console.WriteLine("C. Im depressed ");
            Console.WriteLine("D. I need help");
            answer = Console.ReadLine();
            if (answer == "A")
                Console.WriteLine("you got  right "+correct);
                Console.ReadLine();
            
            //change 




        }
    }
}

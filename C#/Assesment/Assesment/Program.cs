using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Assesment
{ 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            barrel b = new barrel(100);
            b.fill(500);
            b.drain(50);
            Console.WriteLine(b);
            Console.ReadKey();
            
            

           

        }
         
    }
}

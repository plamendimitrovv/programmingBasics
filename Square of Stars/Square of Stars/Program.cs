using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

     //    
            // first row
            Console.WriteLine(new string('*', n));

     
            
            for (double i = 0; i < n - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', n-2));
            }


            // last row
            Console.WriteLine(new string('*', n));
            

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var secs = sec1 + sec2 + sec3;
            var min = 0; 

            if (secs > 59)
            {
                min++;
                secs = secs - 60; 
            }

            if (secs > 59)
            {
                min++;
                secs = secs - 60;
            }

            if (secs > 59)
            {
                min++;
                secs = secs - 60;
            }

            if (secs < 10)
            { Console.WriteLine(min + ":" + "0" + secs); }

            else
            { Console.WriteLine(min + ":" + secs); }

        }
    }
}

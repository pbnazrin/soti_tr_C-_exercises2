using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _6_value
    {
        public static void Main6()
        {
            Console.WriteLine("Enter the value of m");
            int m = int.Parse(Console.ReadLine());
            int n;
            if (m < 0)
            {
               n = -1;

                
            }
            else if (m==0)
            {
                n = 0;
            }
            else
            {
                n = 1;
            }
            Console.WriteLine($"The value of n is {n}");
            Console.ReadKey();
        }
    }
}


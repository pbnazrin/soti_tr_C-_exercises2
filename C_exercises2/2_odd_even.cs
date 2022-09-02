using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _2_odd_even
    {
        public static void Main1()
        {
            Console.WriteLine("Input a number");
            int num = int.Parse(Console.ReadLine());
          
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even number");

                }
                else
                {
                    Console.WriteLine($"{num} is an odd number");
                }

            Console.ReadKey();
            
        }
    }
}

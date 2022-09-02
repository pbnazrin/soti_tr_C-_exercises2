using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _3_positive
    {
        public static void Main3()
        {
            Console.WriteLine("input a number");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine($"{num} is neither positive nor negative");
            }
            else if(num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is positive");
            }
            
            Console.ReadKey();
        }
    }
}

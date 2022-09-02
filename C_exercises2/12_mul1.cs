using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _12_mul1
    {
        public static void Main12()
        {
            Console.WriteLine("Input the number ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");

            }
            Console.ReadKey();
        }
    }
}

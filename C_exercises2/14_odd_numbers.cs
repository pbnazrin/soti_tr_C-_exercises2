using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _14_odd_numbers
    {
        public static void Main14()
        {
            Console.WriteLine("Input number of terms,n");
            int n = int.Parse(Console.ReadLine());
            int sum=0;
            Console.Write("The odd numbers are ");
            for (int i = 1; i <= 2*n; i=i+2)

            {
                Console.Write($"{i} ");
                sum = sum + i;
            }

            Console.WriteLine($"\n The Sum of odd Natural Number upto {n} terms : {sum}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _13_mul_2
    {
        
            public static void Main13()
            {
                Console.WriteLine("Input the number,n ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)

                {
                    Console.WriteLine($"Multiplication table of {i}");

                    for(int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{j} x {i} = {j * i}");
                }

                }
                Console.ReadKey();
            }
        
    }
}

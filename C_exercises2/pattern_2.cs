using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class pattern_2
    {
        public static void Main1()
        {
            Console.WriteLine("Input row number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

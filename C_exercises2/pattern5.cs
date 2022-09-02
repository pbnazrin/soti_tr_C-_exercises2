using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class pattern5
    {
        public static void Main1()
        {
            Console.WriteLine("Input row number");
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            int space = n - 1;
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{counter} ");
                    counter++;
                }
                space--;
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

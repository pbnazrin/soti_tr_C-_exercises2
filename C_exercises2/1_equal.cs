using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Input Ist number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Ist number");
            double num2 = double.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
            Console.ReadKey();
        }
    }
}

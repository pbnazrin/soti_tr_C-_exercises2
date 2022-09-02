using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _8_largest
    {
        public static void Main8()
        {
            Console.WriteLine("Input the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the first number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the first number");
            double num3 = double.Parse(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("Ist  is the geatest among three");


            }else if (num2 > num3)
            {
                Console.WriteLine("2nd  is the geatest among three");
            }
            else
            {
                Console.WriteLine("3rd  is the geatest among three");
            }


            Console.ReadKey();
        }
    }
}

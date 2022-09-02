using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _5_vote
    {
        public static void Main5()
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age <= 20)
            {

                Console.WriteLine("You are not eligible to cast vote");
            }
            else
            {
                Console.WriteLine("You are eligible to cast vote");
            }
            Console.ReadKey();
        }
    }
}

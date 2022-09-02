using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _4_leap_year
    {
        public static void Main4()
        {
            Console.WriteLine("enter a year");
            int year = int.Parse(Console.ReadLine());
            if (year % 100 == 0)
            {
                if(year%400 == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
            else
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
            Console.ReadKey();
        }
       
    }
}

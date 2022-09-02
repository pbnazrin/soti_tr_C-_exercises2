using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _7_height
    {
        public static void Main7()
        {
            Console.WriteLine("Enter the height");
            double height = double.Parse(Console.ReadLine());
           
            if (height <=135 )
            {
                Console.WriteLine($"The person is dwarf");


            }
            else 
            {
                Console.WriteLine($"The person is not dwarf");
            }
            
           
            Console.ReadKey();
        }
    }
}

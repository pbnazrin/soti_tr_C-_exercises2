using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _11_cube
    {
        public static void Main11()
        {
            Console.WriteLine("Input the number of terms");
            int n = int.Parse(Console.ReadLine());
           for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i}");

            }

            
                
            
            Console.ReadKey();
        }
    }
}

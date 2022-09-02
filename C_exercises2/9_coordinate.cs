using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _9_coordinate
    {
        public static void Main9()
        {
            Console.WriteLine("Input the value of X coordinate");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the value of Y coordinate");
            double Y = double.Parse(Console.ReadLine());
            


            if (X>0 && Y>0)
            {
                Console.WriteLine($"the coodinate({X},{Y}) lies in first quadrant ");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine($"the coodinate({X},{Y}) lies in second quadrant ");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine($"the coodinate({X},{Y}) lies in third quadrant ");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine($"the coodinate({X},{Y}) lies in fourth quadrant ");
            }
            else
            {
                Console.WriteLine($"the coodinate({X},{Y}) lies in axis ");
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_exercises2
{
    public class _10_eligibility
    {
        public static void Main10()
        {
            Console.WriteLine("Input the mark obtained in Maths");
            double maths= double.Parse(Console.ReadLine());
            Console.WriteLine("Input the mark obtained in Physics");
            double phy = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the mark obtained in Chemistry");
            double chem = double.Parse(Console.ReadLine());
            double sum = maths + phy + chem;

            if ((maths>=65 && phy>=55 && chem>=50 && sum>=180) ||sum>=140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double ft;
            do
            {
                Console.WriteLine("Enter the number of feet to convert to inches:");
            }
            while (Double.TryParse(Console.ReadLine(), out ft) == false);

            Console.WriteLine($"{ft} ft is equal to {feetToInches(ft)} inches");
        }

        static double feetToInches(double feet)
        {
            
            double inch = feet * 12.00;
            return inch;
        }
    }
}

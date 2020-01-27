using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1A_area
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                // Part 1
                // Area and circumference of a circle:
                Console.WriteLine("\nPart 1, circumference and area of a circle.");
                Console.Write("Enter the radius: ");
                string strradius = Console.ReadLine();
                double dblradius = double.Parse(strradius);
                double circumference = 2 * Math.PI * dblradius;
                Console.WriteLine($"The circumference is: {circumference}");
                double area = Math.PI * Math.Pow(dblradius, 2);
                Console.WriteLine($"The area is: {area}");

                // Part 2
                //Area of a hemisphere ("hemi")
                Console.WriteLine("\nPart 2, volume of a hemisphere.");
                Console.Write("Enter the hemishpere's radius:");
                string strradhemi = Console.ReadLine();
                double radhemi = double.Parse(strradhemi);
                double areahemi = ((4 / 3) * Math.PI * Math.Pow(radhemi, 3)) / 2;
                Console.WriteLine($"The area is: {areahemi}");

                //Part 3
                //Area of a triangle (tri)
                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
                Console.Write("Enter the length of side \'a\' as an integer: ");
                string strsideA = Console.ReadLine();
                double sideA = double.Parse(strsideA);

                Console.Write("Enter the length of side \'b\' as an integer: ");
                string strsideB = Console.ReadLine();
                double sideB = double.Parse(strsideB);

                Console.Write("Enter the length of side \'c\' as an integer: ");
                string strsideC = Console.ReadLine();
                double sideC = double.Parse(strsideC);

                double p = (sideA + sideB + sideC) / 2;
                double areatri = Math.Sqrt(p*(p - sideA)*(p - sideB)*(p - sideC));
                Console.WriteLine($"The area of the triangle is: {areatri}");

                // Part 4
                // Solve a quadratic equation (quad)
                Console.WriteLine("\nPart 4, solving a quadratic equation.\nStandard form: ax^2 + bx + c = 0");
                Console.Write("Enter a non-negative integer for \'a\': ");
                string strgA = Console.ReadLine();
                int intA = Int32.Parse(strgA);
                //Use intA for variable a
                Console.Write("Enter a non-negative integer for \'b\': ");
                string strgB = Console.ReadLine();
                int intB = Int32.Parse(strgB);
                //Use intB for variable b
                Console.Write("Enter a non-negative integer for \'c\': ");
                string strgC = Console.ReadLine();
                int intC = Int32.Parse(strgC);
                //Use intC for variable c

                double xpos = -intB + Math.Sqrt(Math.Pow(intB, 2) - (4 * intA * intC));
                double xneg = -intB - Math.Sqrt(Math.Pow(intB, 2) - (4 * intA * intC));

                double denominator = (2 * intA);

                Console.WriteLine($"The positive solution is: {xpos / denominator}");
                Console.WriteLine($"The negative solution is: {xneg / denominator}");
                Console.ReadLine();
            }
        }
    }
}


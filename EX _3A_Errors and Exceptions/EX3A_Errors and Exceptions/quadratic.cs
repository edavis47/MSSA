using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX__3A_Errors_and_Exceptions
{
    class quadratic
    {
        public void quadraticArea()
        {
            //Does not allow: 1) letters; 2) numbers <= 0; 3) Negative numbers
            Console.WriteLine("Part 4, solving a quadratic equation.\nStandard form: ax^2 + bx + c = 0");

            try
            {
                double A, B, C;
                checked
                {
                    //Variable A
                    Console.Write("Enter a non-negative number for \'a\': ");
                    A = double.Parse(Console.ReadLine());
                    if (A > 0)
                    {
                        //Variable B
                        Console.Write("Enter a non-negative number for \'b\': ");
                        B = double.Parse(Console.ReadLine());
                        if (B > 0)
                        {
                            //Variable C
                            Console.Write("Enter a non-negative number for \'c\': ");
                            C = double.Parse(Console.ReadLine());
                            if (C > 0)
                            {
                                Console.WriteLine($"The positive solution is: {posAreaQuad(A, B, C)}");
                                Console.WriteLine($"The negative solution is: {negAreaQuad(A, B, C)}");
                            }
                            else
                            {
                                quadraticArea();
                            }
                        }
                        else
                        {
                            quadraticArea();
                        }
                    }
                    else
                    {
                        quadraticArea();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
                quadraticArea();
            }
        }

        // Area of a Quadratic:
        static double posAreaQuad(double a, double b, double c)
        {
            double numerator = -b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            double denominator = (2 * a);
            double xpos = numerator / denominator;
            return xpos;
        }
        static double negAreaQuad(double a, double b, double c)
        {
            double numerator = -b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            double denominator = (2 * a);
            double xpos = numerator / denominator;
            return xpos;
        }
    }
}

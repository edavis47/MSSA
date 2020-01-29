using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX__3A_Errors_and_Exceptions
{
    class triangle
    {
        public void triangleArea()
        {
            //Does not allow: 1) letters; 2) numbers <= 0
            Console.WriteLine("Part 3, area of a triangle (Heron's formula).");

            try
            {
                double a = 0, b = 0, c = 0;
                checked
                {
                    //Side a
                    Console.Write("Enter the length of side \'a\': ");
                    a = double.Parse(Console.ReadLine());
                    if (a != 0 && a > 0)
                    {
                        //Side b
                        Console.Write("Enter the length of side \'b\': ");
                        b = double.Parse(Console.ReadLine());
                        if (b != 0 && b > 0)
                        {
                            //Side c
                            Console.Write("Enter the length of side \'c\': ");
                            c = double.Parse(Console.ReadLine());
                            if (c != 0 && c > 0)
                            {
                                Console.WriteLine($"The area of the triangle is {areaTri(a, b, c)}");
                            }
                            else
                            {
                                triangleArea();
                            }
                        }
                        else
                        {
                            triangleArea();
                        }
                    }
                    else
                    {
                        triangleArea();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
                triangleArea();
            }
        }

        // Area of a Triangle:
        static double areaTri(double sideA,double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double areatri = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return areatri;
        }
    }
}

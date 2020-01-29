using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX__3A_Errors_and_Exceptions
{
    class hemisphere
    {
        public void hemisphereArea()
        {
            //Does not allow: 1) letters; 2) numbers <= 0
            double radius;
            Console.WriteLine("Part 2, volume of a hemisphere.");
            Console.Write("Enter the hemishpere's radius:");

            try
            {
                checked
                {
                    radius = Double.Parse(Console.ReadLine());
                    if (radius > 0)
                    {
                        Console.WriteLine($"The area is: {areaHemi(radius)}.");
                    }
                    else
                    {
                        hemisphereArea();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
                hemisphereArea();
            }
        }

        // Area of a hemisphere:
        static double areaHemi(double rad)
        {
            double area = ((4 / 3) * Math.PI * Math.Pow(rad, 3)) / 2;
            return area;
        }
    }
        
}

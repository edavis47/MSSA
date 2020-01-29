using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX__3A_Errors_and_Exceptions
{
    class circle
    {
        public void Circle_CirArea()
        {
            
            double radius;
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Enter the radius: ");

            try
            {
                checked
                {
                    radius = Double.Parse(Console.ReadLine());
                    if (radius > 0)
                    {
                        Console.WriteLine($"The circumference is: {cirCircle(radius)}; and the area is: {areaCircle(radius)}.");
                    }
                    else
                    {
                        Circle_CirArea();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
                Circle_CirArea();
            }
        }

        // Area and circumference of a circle:
        static double cirCircle(double rad)
        {
            double circumference = 2 * Math.PI * rad;
            double area = Math.PI * Math.Pow(rad, 2);
            return circumference;
        }
        static double areaCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}

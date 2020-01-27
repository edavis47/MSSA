using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            int age;
            string input;

            Console.WriteLine("To calculate BMI, enter your weight in pounds:");
            input = Console.ReadLine();
            while (Double.TryParse(input, out weight) == false || weight < 100)
            {
                Console.Write("Error! Enter your weight (in pounds): ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter your age: ");
            input = Console.ReadLine();
            while (Int32.TryParse(input, out age) == false || age < 18)
            {
                Console.Write("Error! Enter your age: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter your height(in inches): ");
            input = Console.ReadLine();
            while (Double.TryParse(input, out height) == false || height < 36)
            {
                Console.Write("Error! Enter your height in inches: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"{CalculateBMI(weight, height)}"); //Actual argument (arg1, arg2)
            Console.ReadKey();
        }

        static string CalculateBMI(double w, double h) //Formal argument (arg1, arg2)
        {
            string returnValue;
            double bmi = (w * 703) / Math.Pow(h, 2);
            if (bmi < 16)
            {
                returnValue = $"Your BMI is: {bmi}.\nYou must add weight";
            }
            else if (bmi >= 16 && bmi < 18.5)
            {
                returnValue = $"Your BMI is: {bmi}.\nYou should add weight.";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                returnValue = $"Your BMI is: {bmi}.\nMaintain your weight";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                returnValue = $"Your BMI is: {bmi}.\nYou should lose some weight";
            }
            else
            { 
                returnValue = $"Your BMI is: {bmi}.\nYou must loose weight";
            }
            return returnValue;
        }
    }
}

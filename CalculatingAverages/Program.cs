using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }
        void run()
        {
            //BASIC DIFFICULTY
            //SUM OF 10 SCORES:

            //Console.WriteLine("To calculate the sum of 10 scores:");
            //Console.WriteLine($"The sum is {CalculateSum()}");


            //AVERAGE 10 SCORES

            //Console.WriteLine("To calculate the average of 10 scores:");
            //double average = CalculateSum() / 10;
            //Console.WriteLine($"The average is {average}; the letter grade is {CalculateGrade(average)}");




            //INTERMEDIATE DIFFICULTY
            //AVERAGE A SPECIFIC NUMBER OF SCORES:

            //Console.WriteLine("Enter the number of tests to be averaged:");
            //int numTest = int.Parse(Console.ReadLine());
            //double avgScore = CalculateSum(numTest) / numTest;
            //Console.WriteLine($"The average is {avgScore}; the letter grade is {CalculateGrade(avgScore)}");




            //Advanced Difficulty
            //AVERAGE A NON SPECIFIC NUMBER OF SCORES

            int total = 0, count = 0;
            string usrInput;
            do
            {
                Console.WriteLine("Enter a test score or \"done\" to complete.");

                usrInput = Console.ReadLine();
                int value = 0;
                if (int.TryParse(usrInput, out value))
                {
                    if (value >= 0 && value <= 100)
                    {
                        total += value;
                        count++;
                    }
                }
            }
            while (usrInput != "done");
            int average = total / count;
            Console.WriteLine($"The average is {average}; the letter grade is {CalculateGrade(average)}");
        }

        private int CalculateSum(int numTests = 10)
        {
            int count = 1, tempNum, sum = 0;
            while (count <= numTests)
            {

                Console.WriteLine($"Enter score {count}");
                tempNum = int.Parse(Console.ReadLine());

                if (tempNum >= 0 && tempNum <= 100)
                {
                    sum += tempNum;
                    count++;
                }
                else Console.WriteLine("Please insert a number between 0 and 100");
            }
            return sum;
        }

        private char CalculateGrade(double gradeAverage)
        {
            if (gradeAverage >= 90) return 'A';
            else if (gradeAverage >= 80) return 'B';
            else if (gradeAverage >= 70) return 'C';
            else if (gradeAverage >= 60) return 'D';
            else return 'F';
        }
            
    }
}

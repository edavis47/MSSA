using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX__3A_Errors_and_Exceptions
{
    class Program
    {
        static void Main()
        {
            StringBuilder mainMenu = new StringBuilder("\nWelcome!");
            mainMenu = mainMenu.Append("\n----------------");
            mainMenu = mainMenu.Append("\n\"C\" = Cirle");
            mainMenu = mainMenu.Append("\n\"H\" = hemisphere");
            mainMenu = mainMenu.Append("\n\"T\" = Triangle");
            mainMenu = mainMenu.Append("\n\"Q\" = Quadratic");
            mainMenu = mainMenu.Append("\n----------------");
            mainMenu = mainMenu.Append("\n\"DONE\" To exit the program.");
            mainMenu = mainMenu.Append("\n----------------");
            mainMenu = mainMenu.Append("\nEnter one of the above values to select and run a program:");
            Console.WriteLine(mainMenu);
            string entry = Console.ReadLine();
            string upperEntry= entry.ToUpper();

            switch (upperEntry)
            {
                case "C":
                    circle c = new circle();
                    c.Circle_CirArea();
                    break;
                case "H":
                    hemisphere h = new hemisphere();
                    h.hemisphereArea();
                    break;
                case "T":
                    //runs again after NaN (2,2,4) - check if/else statements
                    triangle t = new triangle();
                    t.triangleArea();
                    break;
                case "Q":
                    //still runs multiple times after a succesful completion - check if/else statements
                    quadratic q = new quadratic();
                    q.quadraticArea();
                    break;
                case "DONE":
                    Environment.Exit(0);
                    break;
                default :
                    Console.WriteLine("\nPlease enter a correct menu item.\n\n");
                    Main();
                    break;
            }
            Main();

            

            

            

            
        }
    }
}

//Intermediate Difficulty
//Variable overflow
//It's possible that some values may overflow the numeric conctraints. 
//Modify your code (by writing checked/unchecked statements) to protect against numeric overflow errors.

//Advanced Difficulty
//Finally block
//Modify your program to add a finally block.This actually doesn't have to do anything, 
//as we haven't covered network connections, file handles, etc.Just have it print a message such as,
//``This program has finally terminated.''
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
            Console.Write(Menu());
            string userEntry = Console.ReadLine();
            userEntry = userEntry.ToUpper();

            try
            {
                switch (userEntry)
                {
                    case "C":
                        circle circ = new circle();
                        circ.Circle_CirArea();
                        break;
                    case "H":
                        hemisphere hemi = new hemisphere();
                        hemi.hemisphereArea();
                        break;
                    case "T":
                        triangle tri = new triangle();
                        tri.triangleArea();
                        break;
                    case "Q":
                        quadratic quad = new quadratic();
                        quad.quadraticArea();
                        break;
                    case "DONE":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a correct menu item.\n\n");
                        Main();
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThe operation has terminated. Any key will continue.\n");
                Console.ReadKey();
                Main();
            }
            
        }
        static string Menu()
        {
            StringBuilder mainMenu = new StringBuilder("\n MAIN MENU");
            mainMenu = mainMenu.Append("\n-- -- -- -- -- -- -- -- --");
            mainMenu = mainMenu.Append("\n \"C\" = Cirle");
            mainMenu = mainMenu.Append("\n \"H\" = hemisphere");
            mainMenu = mainMenu.Append("\n \"T\" = Triangle");
            mainMenu = mainMenu.Append("\n \"Q\" = Quadratic");
            mainMenu = mainMenu.Append("\n----------------------------");
            mainMenu = mainMenu.Append("\n \"DONE\" to exit the program.");
            mainMenu = mainMenu.Append("\n----------------------------");
            mainMenu = mainMenu.Append("\nEnter one of the above values to select and run a program: ");
            return mainMenu.ToString();
        }
    }
}
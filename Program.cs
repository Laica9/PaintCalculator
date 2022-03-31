using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string program;
            Console.WriteLine("Do you want to use my paint calculator? (Y/N)");
            program = Console.ReadLine();
            program = program.ToUpper();


            while (program == "Y")
            {
                Console.WriteLine("Please enter length of the wall (in meters): ");
                string length = Console.ReadLine();
                Console.WriteLine("Please enter width of the wall (in meters): ");
                string width = Console.ReadLine();
                Console.WriteLine("Please enter height of the wall (in meters): ");
                string height = Console.ReadLine();

                double l = double.Parse(length);
                double w = double.Parse(width);
                double h = double.Parse(height);

                if (l <= 0 || w <= 0 || h <= 0)
                {
                    Console.WriteLine("Sorry, Invalid integer.");
                    Console.WriteLine(" Press R to restart the program...");
                    string restart = Console.ReadLine();

                    while(restart == "R")
                    {
                        
                    }
                }
                else
                {
                    double wallArea = 2 * (l + w);
                    Console.WriteLine("Total measurment: " + wallArea + "meters");
                    double roomArea = wallArea * h;
                    Console.WriteLine("Total area: " + roomArea + " square meters");

                    Console.WriteLine("Please enter number of coats: ");
                    string coat = Console.ReadLine();
                    int c = int.Parse(coat);

                    double squareMetersToBePainted = roomArea * c;
                    Console.WriteLine("Total area to be painted: " + squareMetersToBePainted + " square meters");
                    Console.WriteLine("Please enter paint capacity (per square meter): ");
                    string paint = Console.ReadLine();
                    int p = int.Parse(paint);
                    double required = squareMetersToBePainted / p;
                    double required1 = Math.Round(required, 2);
                    Console.WriteLine("You would need " + required1 + " L of paint.");

                    // required1 / container
                }

                Console.WriteLine("Would you like to use calculator again? (Y/N)");
                program = Console.ReadLine();
                program = program.ToUpper();
            }   
            
        }
    }
}

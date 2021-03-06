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
        /*  Author: Ioanna PK
            Date: 31st March 2022
            Program name: PaintCalculator
            Description: A calculator to estimate the amount of paint needed per room.
                        Displays total price as well. 
                        This program contains feature for user input to restart or stop the program.*/
        static void Main(string[] args)
        {
            string restart = "" ;
            string can1;
            double selectedCan = 0.0;

            string program;
            Console.WriteLine("Do you want to use my paint calculator? (Y/N)");
            program = Console.ReadLine();
            program = program.ToUpper();

            // Start Program 
            while (program == "Y")
            {   
                // Takes user input for wall dimensions (length, width & height)
                Console.WriteLine("Please enter length of the wall (in meters): ");
                string length = Console.ReadLine();
                Console.WriteLine("Please enter width of the wall (in meters): ");
                string width = Console.ReadLine();
                Console.WriteLine("Please enter height of the wall (in meters): ");
                string height = Console.ReadLine();

                // Windows and doors
                Console.WriteLine("Please select how many windows there are: ");
                string windowNum = Console.ReadLine();
                Console.WriteLine("Please enter height of the window (in meters): ");
                string window_h = Console.ReadLine();
                Console.WriteLine("Please enter width of the window (in meters): ");
                string window_w = Console.ReadLine();
                Console.WriteLine("Please select how many doors there are: ");
                string doorNum = Console.ReadLine();
                
                // Standard door sizes
                double doorwidth = 1;
                double doorheight = 2.1;
                double windowN = double.Parse(windowNum);
                double doorN = double.Parse(doorNum);
                double windowHeight = double.Parse(window_h);
                double windowWeight = double.Parse(window_w);

                double l = double.Parse(length);
                double w = double.Parse(width);
                double h = double.Parse(height);

                do
                {
                    // Error handling if user inputs invalid integer
                    if (l <= 0 || w <= 0 || h <= 0)
                    {
                        Console.WriteLine("Sorry, Invalid integer.");
                        Console.WriteLine(" Press R to restart the program...");
                        restart = Console.ReadLine();
                        restart = restart.ToUpper();
                        break;
                    }
                    else
                    {
                        // Wall area calculation
                        double wallArea = 2 * (l + w);
                        Console.WriteLine("Total measurment: " + wallArea + "meters");
                        double roomArea = wallArea * h;
                        double windowedRoom = doorN * (doorheight * doorwidth) + windowN * (windowHeight * windowWeight);
                        double totalArea = roomArea - windowedRoom;
                        Console.WriteLine("Total area: " + totalArea + " square meters");

                        // Prompt user to insert number of coats
                        Console.WriteLine("Please enter number of coats: ");
                        string coat = Console.ReadLine();
                        int c = int.Parse(coat);

                        // Calculating how much paint needed
                        double squareMetersToBePainted = roomArea * c;
                        Console.WriteLine("Total area to be painted: " + squareMetersToBePainted + " square meters");
                        Console.WriteLine("Please enter paint capacity (per square meter): ");
                        string paint = Console.ReadLine();
                        int p = int.Parse(paint);
                        double required = squareMetersToBePainted / p;
                        double required1 = Math.Round(required, 2);
                        Console.WriteLine("You would need " + required1 + " L of paint.");
                        Console.WriteLine("---------------------------------------------");

                        //IGNORE
                        //string[] price = { "\u00A37", "\u00A312", "\u00A317", "\u00A321", "\u00A340" };
                      
                        Console.WriteLine("\nPlease select can size (L): ");
                        string[] cans = {"0.5","1","2.5", "5", "10" };
                        
                        for (int i = 0; i < cans.Length; i++)
                        {
                            Console.Write(cans[i] + " | ");
                        }

                        Console.WriteLine("");
                        can1 = Console.ReadLine();

                        // Error handling
                        if (cans.Contains(can1))
                        {
                            selectedCan = double.Parse(can1);
                            double cansNeeded = required1 / selectedCan;
                            double totalPrice = 0.0;

                            // Show price after size can has been selected. 
                            switch (can1)
                            {
                                case "0.5":
                                    string str1 = "7";
                                    Console.WriteLine("Price for " + can1 + " litres per can is: \u00A3" + str1);
                                    double p1 = double.Parse(str1);
                                    totalPrice = cansNeeded * p1;
                                    break;
                                case "1":
                                    string str2 = "12";
                                    Console.WriteLine("Price for " + can1 + " litres per can is: \u00A3" + str2);
                                    double p2 = double.Parse(str2);
                                    totalPrice = cansNeeded * p2;
                                    break;
                                case "2.5":
                                    string str3 = "17";
                                    Console.WriteLine("Price for " + can1 + " litres per can is: \u00A3" + str3);
                                    double p3 = double.Parse(str3);
                                    totalPrice = cansNeeded * p3;
                                    break;
                                case "5":
                                    string str4 = "21";
                                    Console.WriteLine("Price for " + can1 + " litres per can is: \u00A3" + str4);
                                    double p4 = double.Parse(str4);
                                    totalPrice = cansNeeded * p4;
                                    break;
                                case "10":
                                    string str5 = "40";
                                    Console.WriteLine("Price for " + can1 + " litres per can is: \u00A3" + str5);
                                    double p5 = double.Parse(str5);
                                    totalPrice = cansNeeded * p5;
                                    break;
                                default:
                                    Console.WriteLine("__");
                                    break;
                            }


                            Console.WriteLine("\n You selected " + can1 + " L capacity.\n You would need " + cansNeeded + " cans.");
                            Console.WriteLine("\n Total price: " + totalPrice + "\u00A3");
                            Console.WriteLine("---------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, invalid option.");
                        }

                        // Colour Quizz
                        Console.WriteLine("Lastly, I will place you to which nation you belong from the Avatar, The Last Airbender.");
                        Console.WriteLine("Choose your colour: ");
                        Console.WriteLine("1. Blue");
                        Console.WriteLine("2. Green");
                        Console.WriteLine("3. Red");
                        Console.WriteLine("4. Gray");
                        Console.WriteLine("Choice: ");
                        string choice = Console.ReadLine().ToLower();

                        switch (choice)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Noice, you belong to water nation");
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("soil nation");
                                    break;                             
                                }
                            case"3":
                                {
                                    Console.WriteLine("Fire nation. That's bonkers.");
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("You're BREATHtakig (air nation)");
                                    break;
                                }
                        }
                        Console.WriteLine("The end");
                    }
                } while (restart == "R");

                Console.WriteLine("\nWould you like to use calculator again? (Y/N)");
                program = Console.ReadLine();
                program = program.ToUpper();
            }   
            
        }
    }
}

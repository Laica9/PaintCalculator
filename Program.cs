using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string intro = "Hi, I'm Jojo and I like anime.";
            int year = 2022;
            Console.WriteLine("\t" + intro + "\n" + "\tToday's date: 30th March " + year);
            //Console.ReadKey();
            //int result = (int)Math.Round(paintRequired); -- IGNORE

            int Wall1_width = 1;
            int depth = 2;
            int height = 2;
            int wallArea = Wall1_width * depth * height;

            Console.WriteLine();    
            Console.WriteLine("The surface area of the wall is: " + wallArea);

            /*
                Calculator to caluculate how much paint do I need 
                to paint a wall surface area
             */

            Console.WriteLine("============================================");
            Console.WriteLine("Please enter height of the wall: ");
            string height1 = Console.ReadLine();
            Console.WriteLine("Please enter length of the wall: ");
            string length = Console.ReadLine();
            Console.WriteLine("Please enter width of the wall: ");
            string width1 = Console.ReadLine();

            Console.WriteLine("\nHeight value of the wall entered ==> " + height1 + "m");
            Console.WriteLine("\nLength value of the wall entered ==> " + length + "m");
            Console.WriteLine("\nWidth value of the wall entered ==> " + width1 + "m");

            int w = int.Parse(width1);
            int h = int.Parse(height1);
            int l = int.Parse(length);
            double roomArea = 2 * (l + w) * h;
            Console.WriteLine("\nTotal room area : " + roomArea + "m\u00b2");
            Console.WriteLine("\n=======================================================");
            // It is assumed there is 350 square feet per gallon
            double squareftPerGallon = 350;
            double numberOfGallons = roomArea / squareftPerGallon;
            Console.WriteLine("\nGallons needed: " + numberOfGallons);


            // Paint required = pintable surface area / 10 (1L of paint will cover between
            // 10 meters squared of wall. 
            //double paintRequired = roomArea  / 10;
            //double result = Math.Round(paintRequired,2);
            //Console.WriteLine("Paint required around: " + result + " L");
        }
    }
}

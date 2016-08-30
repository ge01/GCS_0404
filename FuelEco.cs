using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0404_083016
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;       // To hold miles driven
            double gallons;     // To hold gallons used
            double mpg;         // To hold MPG

            // Get the miles driven and assign it to 
            // the strMiles variable.
            Console.Write("Enter the number of miles driven: ");
            string strMiles = Console.ReadLine();

            // Get the gallons used and assign it to 
            // the strGallons variable.
            Console.Write("Enter the number of gallons used: ");
            string strGallons = Console.ReadLine();

            // Validate the miles
            if (double.TryParse(strMiles, out miles))
            {                
                // Validate the gallons
                if (double.TryParse(strGallons, out gallons))
                {
                    // Calculate MPG
                    mpg = miles / gallons;

                    // Display the MPG in the mpgLabel control.
                    Console.WriteLine("Your car's MPG: " + mpg.ToString("n1"));
                    Console.ReadLine();
                }
                else
                {
                    // Display an erro message for gallons
                    Console.WriteLine("Your input {0} is invalid for gallons.", gallons);
                    Console.ReadLine();
                }
            }
            else
            {
                // Display an error message for miles.
                Console.WriteLine("Your input {0} is invalid input for miles.", miles);
                Console.ReadLine();
            }
        }
    }
}

// https://www.youtube.com/watch?v=LB2cc16_SE4

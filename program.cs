using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display the mandatory welcome message on the first line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // 3. Check if the weight is greater than 50. If so, display error and exit.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program
            }

            // 4. Prompt for the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // 5. Prompt for the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // 6. Prompt for the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // 7. Check if the total of the dimensions (width + height + length) is greater than 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program
            }

            // 8. Multiply the three dimensions together, multiply by weight, then divide by 100
            double quote = (width * height * length * weight) / 100;

            // 9 & 10. Display the resulting quote as a formatted dollar amount (2 decimal places)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}

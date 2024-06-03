using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the method to sum integers and doubles
            SumIntegersAndDoubles();

            // Ask user to enter an integer and compute the sum of its digits
            Console.WriteLine("Enter an integer number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int sumOfDigits = SumOfDigits(number);
                Console.WriteLine($"Sum of individual digits: {sumOfDigits}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }

            Console.ReadLine();
        }

        static void SumIntegersAndDoubles()
        {
            object[] obj = { 12, 2.5, 8, 5.5, "monday", "tuesday" };

            double sum = 0;
            foreach (var item in obj)
            {
                if (item is int)
                {
                    sum += (int)item;
                }
                else if (item is double)
                {
                    sum += (double)item;
                }
            }

            Console.WriteLine($"Sum of integers and doubles: {sum}");
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
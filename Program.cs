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

            // Check if a string is a palindrome
            Console.WriteLine("Enter a string to check if it's a palindrome:");
            string inputString = Console.ReadLine();
            bool isPalindrome = IsPalindrome(inputString);
            Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");

            // Reverse an array
            int[] rev = new[] { 1, 2, 3, 4, 5, 6 };
            ReverseArray(rev);
            Console.WriteLine("Reversed array: " + string.Join(" ", rev));

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

        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        static void ReverseArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }
    }
}
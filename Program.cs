using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.ReadLine();
        }
    }
}
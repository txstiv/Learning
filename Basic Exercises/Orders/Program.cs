using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOrders = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= numbersOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int numberOfCapsules = int.Parse(Console.ReadLine());

                total += (days * numberOfCapsules) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${(days * numberOfCapsules) * pricePerCapsule:f2}");
            }

            Console.WriteLine($"Total: ${total:F2}");
            //Basic Calculations with simple code !
        }
    }
}

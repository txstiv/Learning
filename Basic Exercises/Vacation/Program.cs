using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numpeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double totalSum = 0;
            
            if(day == "Friday")
            {
                if(typeGroup == "Students")
                {
                    totalSum = numpeople * 8.45;
                    if(numpeople >= 30)
                    {
                        totalSum = totalSum - (totalSum * 0.15);
                    }
                }
                else if (typeGroup == "Business")
                {
                    totalSum = numpeople * 10.90;
                    if(numpeople >= 100)
                    {
                        totalSum = totalSum - 109;
                    }
                }
                else if(typeGroup == "Regular")
                {
                    totalSum = numpeople * 15;
                    if(numpeople >= 10 && numpeople <= 20)
                    {
                        totalSum = totalSum - (totalSum * 0.05);
                    }
                }
            }
            else if(day == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    totalSum = numpeople * 9.80;
                    if (numpeople >= 30)
                    {
                        totalSum = totalSum - (totalSum * 0.15);
                    }
                }
                else if (typeGroup == "Business")
                {
                    totalSum = numpeople * 15.60;
                    if (numpeople >= 100)
                    {
                        totalSum = totalSum - 156;
                    }
                }
                else if (typeGroup == "Regular")
                {
                    totalSum = numpeople * 20;
                    if (numpeople >= 10 && numpeople <= 20)
                    {
                        totalSum = totalSum - (totalSum * 0.05);
                    }
                }
            }
            else if(day == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    totalSum = numpeople * 10.46;
                    if (numpeople >= 30)
                    {
                        totalSum = totalSum - (totalSum * 0.15);
                    }
                }
                else if (typeGroup == "Business")
                {
                    totalSum = numpeople * 16;
                    if (numpeople >= 100)
                    {
                        totalSum = totalSum - 160;
                    }
                }
                else if (typeGroup == "Regular")
                {
                    totalSum = numpeople * 22.50;
                    if (numpeople >= 10 && numpeople <= 20)
                    {
                        totalSum = totalSum - (totalSum * 0.05);
                    }
                }
            }

            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}

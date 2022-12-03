using System;

namespace Padawen_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnMoney = double.Parse(Console.ReadLine()); // Johns total money.
            int countStudents = int.Parse(Console.ReadLine()); // number of students. 
            double priceOfLightsabers = double.Parse(Console.ReadLine()); // Price of single Lightsaber.
            double priceOfRobes = double.Parse(Console.ReadLine());// Price of single Robe.
            double priceOfBelts = double.Parse(Console.ReadLine());// Price of single Belt.

            double totalNumberLightsabers = Math.Ceiling(countStudents * 1.10); // John should buy 10% more .
            double freeBelts = Math.Floor(countStudents / 6.0); // Every sixth belt is free .

            double finalLightsabersPrice = totalNumberLightsabers * priceOfLightsabers;
            double finalRobesPrice = countStudents * priceOfRobes;
            double finalBeltsPrice = (countStudents - freeBelts) * priceOfBelts;

            double totalMoneyNeeded = finalLightsabersPrice + finalRobesPrice + finalBeltsPrice;

            if (johnMoney < totalMoneyNeeded)
            {
                Console.WriteLine($"John will need {Math.Abs(johnMoney - totalMoneyNeeded):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
            }
        }
    }
}

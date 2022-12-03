using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double kayboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;
            double trashedKeyboards = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboards++;
                    rageExpenses += kayboardPrice;
                    if (trashedKeyboards % 2 == 0)
                    {
                        rageExpenses += displayPrice;
                    }
                    
                    
                }
                if(i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                if(i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
                


            }

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}

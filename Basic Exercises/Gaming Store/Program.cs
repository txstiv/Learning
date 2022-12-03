using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var outFall = 39.99;
            var csGo = 15.99;
            var splinterCell = 19.99;
            var honored = 59.99;
            var overWatch = 29.99;
            var overWatchOeDition = 39.99;

            var balance = double.Parse(Console.ReadLine());
            var pick = Console.ReadLine();
            var costs = balance;
            var total = 0.00;
            while(pick != "Game Time")
            {
                switch(pick)
                {
                    case "OutFall 4":
                        if(costs >= outFall)
                        {
                            Console.WriteLine($"Bought OutFall 4");
                            costs -= outFall;
                            total += outFall;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (costs >= csGo)
                        {
                            Console.WriteLine($"Bought CS: OG");
                            costs -= csGo;
                            total += csGo;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        
                        break;
                    case "Zplinter Zell":
                        if (costs >= csGo)
                        {
                            Console.WriteLine($"Bought Zplinter Zell");
                            costs -= splinterCell;
                            total += splinterCell;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        
                        break;
                    case "Honored 2":
                        if (costs >= csGo)
                        {
                            Console.WriteLine($"Bought Honored 2");
                            costs -= honored;
                            total += honored;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        
                        break;
                    case "RoverWatch":
                        if (costs >= overWatch)
                        {
                            Console.WriteLine($"Bought RoverWatch");
                            costs -= overWatch;
                            total += overWatch;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }

                        break;
                    case "RoverWatch Origins Edition":
                        if (costs >= csGo)
                        {
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                            costs -= overWatchOeDition;
                            total += overWatchOeDition;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                
                
                    pick = Console.ReadLine();
                

            }

            

            if( costs == 0 )
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${costs:f2}");
            }
            

        }
    }
}

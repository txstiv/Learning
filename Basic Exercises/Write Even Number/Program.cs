﻿using System;

namespace Write_Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int i = number; i > 0; i++)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}

﻿using System;

namespace Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 30;

            if(minute >59)
            {
                hour += 1;
                minute -= 60;
            }
            if(hour > 23)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{minute:D2}");


        }
    }
}

using System;

namespace Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int start = 1;

            while(n > 0)
            {
                Console.WriteLine(start);

                sum += start;

                start += 2;

                n--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

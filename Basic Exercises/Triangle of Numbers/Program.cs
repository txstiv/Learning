using System;

namespace Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int x = 0;
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    int x = i;
                    Console.Write($"{x} ");
                }
                Console.WriteLine();
            }


        }
    }
}

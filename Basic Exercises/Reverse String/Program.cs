using System;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gnirts = Console.ReadLine();

            string reverse = "";

            int lenght = gnirts.Length -1;

            while(lenght >= 0)
            {
                reverse = reverse + gnirts[lenght];
                lenght--;
            }
            Console.WriteLine(reverse);
        }
    }
}

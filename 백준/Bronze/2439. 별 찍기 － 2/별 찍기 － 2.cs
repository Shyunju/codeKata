using System;

namespace for문10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
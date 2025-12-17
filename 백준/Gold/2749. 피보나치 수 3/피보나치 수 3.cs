using System;

public class Program
{
    public static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        const int MOD = 1000000;
        const int PISANO = 1500000;

        // 피사노 주기를 이용해 n을 줄임
        int reducedN = (int)(n % PISANO);

        if (reducedN == 0)
        {
            Console.WriteLine(0);
            return;
        }
        if (reducedN == 1 || reducedN == 2)
        {
            Console.WriteLine(1);
            return;
        }

        int a = 1; 
        int b = 1;
        int c = 0;

        for (int i = 3; i <= reducedN; i++)
        {
            c = (a + b) % MOD;
            a = b;
            b = c;
        }

        Console.WriteLine(b);
    }
}


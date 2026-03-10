using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int[,] comb = new int[1002,1002];
        int mod = 10007;
        
        for(int i = 1; i <= 1000; i++)
        {
            comb[i,0] = comb[i,i] = 1;
            for(int j = 1; j< i; j++)
            {
                comb[i,j] = (comb[i-1,j] + comb[i-1,j-1]) % mod;
            }
        }
        string[] sl = Console.ReadLine().Split();
        int n = int.Parse(sl[0]);
        int m = int.Parse(sl[1]);
        Console.WriteLine(comb[n,m]);
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int answer = 0;
        string[] sl = Console.ReadLine().Split();
        
        int n = int.Parse(sl[0]);
        int k = int.Parse(sl[1]);
        
        List<int> coin = new List<int>();
        for(int i = 0; i < n; i++)
        {
            coin.Add(int.Parse(Console.ReadLine()));
        }
        coin.Reverse();
        while( k > 0)
        {
            if(k / coin[0] > 0)
            {
                answer += k/coin[0];
                k %= coin[0];
            }
            coin.RemoveAt(0);
        }
        Console.WriteLine(answer);
    }
}
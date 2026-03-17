using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        List<int> w = new List<int>();
        for(int i= 0; i <n; i++)
        {
            w.Add(int.Parse(Console.ReadLine()));
        }
        w.Sort();
        int max = 0;
        for(int i =1; i <= n; i++)
        {
            max = Math.Max(max, w[n-i]*i);
        }
        Console.Write(max);
    }
}
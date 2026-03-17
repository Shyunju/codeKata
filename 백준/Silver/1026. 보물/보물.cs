using System;
using System.Collections.Generic;

public class Progrma
{
    static void Main(string[] args)
    {
        Progrma p = new Progrma();
        
        int n = int.Parse(Console.ReadLine());
        string[] input1 = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();
        List<int> a = new List<int>();
        List<int> b = new List<int>();
        
        for(int i = 0; i <n; i++)
        {
            a.Add(int.Parse(input1[i]));
            b.Add(int.Parse(input2[i]));
        }
        a.Sort();
        b.Sort();
        b.Reverse();
        int s = 0;
        for(int i =0;i <n;i++)
        {
            s += a[i] * b[i];
        }
        Console.Write(s);
    }
}
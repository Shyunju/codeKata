using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        (int start, int end)[] time = new(int, int)[n];
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int s = int.Parse(input[0]);
            int e = int.Parse(input[1]);
            
            time[i] = (s, e);
        }
        Array.Sort(time, (x,y) => p.Compare(x,y));
        int answer = 0;
        int t = 0;
        foreach(var cur in time)
        {
            if(t <= cur.start)
            {
                t = cur.end;
                answer++;
            }
        }
        Console.WriteLine(answer);
    }
    public int Compare((int start, int end)x, (int start, int end)y)
    {
        if(x.end == y.end)
        {
            if(x.start < y.start) return -1;
            return 1;
        }else
        {
            if(x.end < y.end) return -1;
            return 1;
        }
    }
}
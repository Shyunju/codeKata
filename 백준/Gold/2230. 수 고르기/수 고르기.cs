using System;
using System.Collections.Generic;

public class Solution
{
    static void Main(string[] args)
    {
        var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int n = input[0];
        int m = input[1];
        
        List<int> list = new List<int>();
        for(int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        list.Sort();
        int ans = int.MaxValue;
        int st = 0;
        int en = 0;
        while(st < n)
        {
            if(list[en] - list[st] >= m)
            {
                ans = Math.Min(ans, list[en] - list[st]);
                st++;
            }
            else
            {
                if(en < n-1)
                    en++;
                else
                    st++;
            }
        }
        Console.Write(ans);
        
    }
}
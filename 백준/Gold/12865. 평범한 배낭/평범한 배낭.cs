using System;
using System.Collections.Generic;
public class Solution
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int n = input[0];
        int limit = input[1];
        List<(int w, int v)> list = new List<(int w, int v)>();
        for(int i =0;i < n; i++)
        {
            var ob = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            list.Add((ob[0], ob[1]));
        }
        int[] dp = new int[limit+1];
        for(int i = 0; i < list.Count(); i++)
        {
            var cur = list[i];
            if(cur.w > limit)
                continue;
            for(int j = limit; j >= cur.w; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - cur.w] + cur.v);
            }
        }
        Console.Write(dp.Max());
    }
}
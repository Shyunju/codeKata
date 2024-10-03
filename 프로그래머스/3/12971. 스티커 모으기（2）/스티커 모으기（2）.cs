using System;
using System.Linq;
class Solution
{
    public int solution(int[] sticker)
    {
        if(sticker.Length == 1)  return sticker[0];
        
        var dp = new int[sticker.Length];
        var dp2 = new int[sticker.Length];
        
        dp[0]= sticker[0];
        dp[1]= sticker[0];
        dp2[0] = 0;
        dp2[1] = sticker[1];
        
        for(int i = 2; i< sticker.Length -1; i++)
            dp[i] = Math.Max(dp[i -2] + sticker[i], dp[i -1]);
        
        int value1 = dp.Max();
        for(int i = 2; i < sticker.Length; i++)
            dp2[i] = Math.Max(dp2[i-2] + sticker[i], dp2[i-1]);
        
        int value2 =dp2.Max();
        
        return Math.Max(value1, value2);
    }
}
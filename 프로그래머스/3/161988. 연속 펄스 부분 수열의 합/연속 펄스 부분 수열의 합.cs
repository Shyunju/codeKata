using System;
using System.Linq;

public class Solution
{
    public long GetMaxAccValue(int[] intArray)
    {
        long[] dp = new long[intArray.Length];
        
        dp[0] = Math.Max(0, intArray[0]);
        for(int i = 1; i < dp.Length; i++)
            dp[i] = Math.Max(0, dp[i - 1]) + intArray[i];
        
        return dp.Max();
    }
    
    public long solution(int[] sequence)
    {
        int[] sequence2 = (int[])sequence.Clone();
        bool isCheck = false;
        
        for(int i = 0; i < sequence.Length; i++)
        {
            if(isCheck)
                sequence[i] *= -1;
            else
                sequence2[i] *= -1;
            
            isCheck = !isCheck;
        }
        
        return Math.Max(GetMaxAccValue(sequence), GetMaxAccValue(sequence2));
    }
}

using System;
public class Solution {
    public long solution(int n) {
        long answer = 0;
        long[] count = new long[n+1];
        
        for(int i = 1; i <= n ; i++)
        {
            if(i <= 2)
            {
                count[i] = i;
                continue;
            }
            count[i] = (count[i-1] + count[i-2]) % 1234567;
        }
        
        return answer = count[n];
    }
}
using System;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n <= 3)
            return n;
        int dp1 = 2;
        int dp2 = 3;
        
        
        while(n > 3)
        {
            answer = (dp1 + dp2) % 1234567;
            
            dp1 = dp2;
            dp2 = answer;
            --n;
        }
        
        return answer;
    }
}
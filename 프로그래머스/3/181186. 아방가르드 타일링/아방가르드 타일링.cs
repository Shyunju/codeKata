using System;

public class Solution {
    public int solution(int n) {
        long[] dp = new long[n+2];
        long per = 1000000007;
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 3;
        
        for(int i = 3; i <=n; i++){
            long sum = dp[i-1] + dp[i-2] * 2 + dp[i-3] * 5;
            int turn = 0;
            for(int j = i-4; j >= 0; j--){
                if(turn == 2){
                    sum += dp[j] * 4;
                    turn = 0;
                }else{
                    sum += dp[j] * 2;
                    turn++;
                }
            }
            dp[i] = sum % per;
        }
        return (int)(dp[n] % per);
    }
}
using System;

public class Solution {
    public int solution(int n, int[] tops) {
        int[] visited = new int[200005];
        int[] dp = new int[200005];
        
        for(int i = 0; i < tops.Length; i++){
            if(tops[i] == 1)
                visited[i*2+1] = 1;
        }
        dp[0] = 1;
        dp[1] = 2;
        if(visited[1] == 1)
            dp[1] = 3;
        
        for(int j =2; j <= 2*n; j++){
            if(j%2 == 1 && visited[j] == 1)
                dp[j] = dp[j-1] + dp[j-1] + dp[j-2];
            else
                dp[j] = dp[j-1] + dp[j-2];
            
            dp[j] %= 10007;
        }
        return dp[2*n];
    }
}
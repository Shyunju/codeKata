using System;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        int[,] dp = new int[2501,2501];
        char[] arr = new char[2501];
        
        for(int i = 0; i < s.Length; i++)
            arr[i+1] = s[i];
        
        for(int i = s.Length; i > 0; i--){
            for(int j = i; j <= s.Length; j++){
                if(i == j) dp[i,j] = 1;
                else if(arr[i] == arr[j] && dp[i+1, j-1] != -1) 
                    dp[i,j] = dp[i+1, j-1] +2;
                else
                    dp[i,j] = -1;
                
                answer = Math.Max(answer,dp[i,j]);

            }
        }

        return answer;
    }
}
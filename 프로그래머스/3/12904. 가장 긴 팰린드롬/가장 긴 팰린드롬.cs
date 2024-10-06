using System;
public class Solution {
    static int[,] dp = new int[2501,2501];
    static char[] arr = new char[2501];
    public int solution(string s) {
        for(int i = 0; i < s.Length; i++) arr[i+1] = s[i];
        
        int answer = 0;
        for(int i = s.Length; i > 0; i--){
            for(int j = i; j <= s.Length; j++){
            	// 원소가 1개 일때는 무조건 팰린드롬, 길이가 1
                if(i == j) dp[i,j] = 1;
                // 점화식대로 해줌
                else if(arr[i] == arr[j] && dp[i+1,j-1] != -1){
                    dp[i,j] = dp[i+1,j-1]+2;
                }
                else dp[i,j] = -1;
                
                // 길이가 가장 긴 것을 정답으로
                answer = Math.Max(answer,dp[i,j]);
            }
            
        }

        return answer;
    }
}
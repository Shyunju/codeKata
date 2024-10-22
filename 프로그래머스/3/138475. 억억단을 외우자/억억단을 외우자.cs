using System;

public class Solution {
    public int[] solution(int e, int[] starts) {
        int[] answer = new int[starts.Length];
        int[] countArr = new int[e+1];
        int[] dp = new int[e+1];
        
        for(int i = 1; i <= e; i++){
            for(int j = 1; j <= e; j++){
                if(i * j > e) break;
                countArr[i*j]++;
            }
        }
        int maxCnt = -1;
        int index = -1;
        for(int i = e; i > 0; i--){
            if(maxCnt <= countArr[i]){
                maxCnt = countArr[i];
                index = i;
            }
            dp[i] = index;
        }
        for(int i = 0; i < starts.Length; i++)
            answer[i] = dp[starts[i]];
        return answer;
    }
}
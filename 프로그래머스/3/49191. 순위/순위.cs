using System;

public class Solution {
    public int solution(int n, int[,] results) {
        int answer = 0;
        var history = new bool[n+1, n+1];
        
        for(int i = 0; i < results.GetLength(0); i++)
            history[results[i,0], results[i,1]] = true;
        
        for(int i = 1; i <= n; i++){
            for(int win = 1; win <= n; win++){
                for(int lose = 1; lose <= n; lose++){
                    if(history[win, i] && history[i, lose])
                        history[win, lose] = true;
                }
            }
        }
        for(int i=1; i <= n; i++){
            int count = 0;
            for(int j= 1; j <= n; j++){
                if(history[i,j] || history[j,i]) 
                    count++;
            }
            if(count + 1 == n)
                answer++;
        }
        return answer;
    }
}
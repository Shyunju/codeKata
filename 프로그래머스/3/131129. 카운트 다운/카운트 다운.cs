using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int target) {
        int[] answer = new int[2];
        int[,] dp = new int[target + 1, 2];
        Queue<int[]> q = new Queue<int[]>();
        
        q.Enqueue(new int[] {0, 0, 0});
        
        while(q.Count > 0){
            int[] data = q.Dequeue();
            
            if(data[1] > dp[data[0], 0] || ( data[1] == dp[data[0],0] && data[2] <= dp[data[0],1])){
                if(dp[data[0], 0] != 0) continue;
            }
            dp[data[0], 0] = data[1];
            dp[data[0], 1] = data[2];
            
            if(data[0] + 20 <= target)
                q.Enqueue(new int[]{data[0]+20, data[1]+1, data[2]+1});
            else
                q.Enqueue(new int[]{target, data[1]+1, data[2]+1});
            
            if(data[0] + 50 <= target)
                q.Enqueue(new int[]{data[0] + 50, data[1]+1, data[2]+1 });
            
            for(int i = 22; i <= 40; i+=2)
                if(data[0] + i <= target)
                    q.Enqueue(new int[]{data[0]+i, data[1]+1, data[2]});
            for(int i = 21; i <= 60; i+=3)
                if(data[0] + i <= target)
                    q.Enqueue(new int[]{data[0]+i, data[1]+1, data[2]});
        }
        answer[0] = dp[target, 0];
        answer[1] = dp[target, 1];
        return answer;
    }
}
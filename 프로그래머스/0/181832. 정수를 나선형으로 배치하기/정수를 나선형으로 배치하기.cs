using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        int[] dirY = new int[] {0,1,0,-1};
        int[] dirX = new int[] {1,0,-1,0};
        
        int idx = 0;
        int cnt = 1;
        int y = 0;
        int x = 0;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                answer[y,x] = cnt;
                cnt++;
                if(y+dirY[idx] >= n || y+dirY[idx] < 0 || x+dirX[idx] >= n || x+dirX[idx] < 0 || answer[y+dirY[idx], x + dirX[idx]] != 0)
                {
                    idx++;
                    if(idx == 4)
                        idx = 0;
                }
                y += dirY[idx];
                x += dirX[idx];
            }
        }
        return answer;
    }
}
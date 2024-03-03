using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {int.MaxValue, int.MaxValue, 0, 0};
        
        for(int i = 0; i < wallpaper.Length; i++)
        {
            for(int j = 0 ; j <wallpaper[i].Length; j++)
            {
                if(wallpaper[i][j] == '#')
                {
                    answer[0] = Math.Min(answer[0], i);
                    answer[1] = Math.Min(answer[1], j);
                    answer[2] = Math.Max(answer[2], i+1);
                    answer[3] = Math.Max(answer[3], j+1);
                }
            }
        }
        return answer;
    }
}
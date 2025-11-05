using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int all = brown + yellow;
        int max = (int)Math.Sqrt(all);
        for(int i = 3; i <= max; i++)
        {
            int height = i - 2;
            int width = (brown - (i * 2)) / 2;
            
            if(height * width == yellow)
            {
                answer[0] = width + 2;
                answer[1] = height + 2;
                break;
            }
        }
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        int all = brown + yellow;
        
        for(int i = 1; i <= all; i++)
        {
            int h = i;
            int w = all / i;
            if( h > w || w == h)
            {
                if( all - (w*2 + h*2 - 4) == yellow)
                {
                    answer[0]= h;
                    answer[1]= w;
                    break;
                }
            }
            
        }
        return answer;
    }
}
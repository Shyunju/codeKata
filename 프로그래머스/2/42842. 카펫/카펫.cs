using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        int width = 0;
        int height = 0;
        
        for(int i = 1; i<=yellow; i++)
        {
            if(yellow%i==0)
            {
                width = yellow/i;
                height = i;

                if(height<=width)
                {
                    if((width+2) * (height+2) == brown + yellow)
                    {
                        answer = new int[] {width+2, height+2};
                        return answer;
                    }
                }
            }
        }
         return answer;
    }
}
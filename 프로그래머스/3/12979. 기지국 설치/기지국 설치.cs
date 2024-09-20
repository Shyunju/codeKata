using System;

class Solution
{
    public int solution(int n, int[] stations, int w){
        int answer =0;
        int width = 2 * w +1;
        int idx = 1;
        
        foreach(int i in stations){
            int blank = i - w - idx;
            if(blank > 0)
                answer += (blank + width - 1) / width;
            idx = i + w + 1;
        }
        int last = n + 1 - idx;
        if(last > 0)
            answer += (last + width -1) / width;

        return answer;
    }
}
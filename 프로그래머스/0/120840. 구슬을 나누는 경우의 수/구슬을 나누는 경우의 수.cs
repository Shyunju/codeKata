using System;

public class Solution {
    public int solution(int balls, int share) {
        if(balls == share) return 1;
        long answer = 1;
        int idx = 1;
        for(int i = share + 1; i <= balls; i++)
        {
            answer *= i;
            answer /= idx++;
        }
        
        return (int)answer;
    }
}
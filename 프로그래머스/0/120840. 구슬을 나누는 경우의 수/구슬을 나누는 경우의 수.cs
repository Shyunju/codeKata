using System;

public class Solution {
    public long solution(int balls, int share) {
        long answer = 1;
        int cnt = 1;
        
        while(cnt <= share)
        {
            answer *= balls--;
            answer /= cnt++; 
        }
        return answer;
    }
    
   
}
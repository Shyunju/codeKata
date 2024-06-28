using System;

public class Solution {
    public int solution(int storey) {
        int answer = 0;
        int r;
        while(storey > 0)
        {
            storey = Math.DivRem(storey, 10, out r);
            if(r > 5 || (r == 5 && (storey % 10 >= 5)))
            {
                answer += 10 - r;
                storey += 1;       
            }
            else answer += r;
        }
        return answer;
    }
}
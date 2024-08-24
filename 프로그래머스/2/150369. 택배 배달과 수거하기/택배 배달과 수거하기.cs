using System;

public class Solution {
    public long solution(int cap, int n, int[] deliveries, int[] pickups) 
    {
        long answer = 0;
        int deliver = 0;
        int pick = 0;

        for(int i = n - 1; i >= 0; --i)
        {
            if(deliveries[i] == 0 && pickups[i] == 0)
                continue;

            int repeat = 0;
            while(deliver < deliveries[i] || pick < pickups[i])
            {
                deliver += cap;
                pick += cap;
                ++repeat;
            }

            deliver -= deliveries[i];
            pick -= pickups[i];

            answer += ((long)(i + 1) * repeat);
        }

        return answer * 2; // 왕복 거리
    }

}
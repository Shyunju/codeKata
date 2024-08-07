using System;

public class Solution {
    public long solution(int r1, int r2) {
        long answer = 0;
        long c1 = (long)r1 * (long)r1;
        long c2 = (long)r2 * (long)r2;
        
        for(long x = 0; x < r2; x++){
            if(x == 0)
                answer += r2 -r1 +1;
            else if(x >= r1){
                double y = Math.Sqrt(c2 - x *x);
                answer += (int)Math.Floor(y);
            }else{
                long xx = x*x;
                double y2 = Math.Sqrt(c2 - xx);
                double y1 = Math.Sqrt(c1 - xx);
                
                int floor = (int)Math.Floor(y2);
                int ceil = (int)Math.Ceiling(y1);
                answer += floor - ceil + 1;
            }
        }
        return answer * 4;
    }
}
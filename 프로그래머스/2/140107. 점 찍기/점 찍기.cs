using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0;
        long dd = (long)d*d;
        
        for(long i = 0; i <=d ; i += k){
            long y = (long)Math.Sqrt(dd - i*i) / k;
            answer += (y +1);
        }
        return answer;
    }
}
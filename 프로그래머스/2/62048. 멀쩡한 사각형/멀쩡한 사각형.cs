using System;

class Solution {
    public long solution(long w,long h) {
        long lgcd = gcd(w, h);
        long answer = w * h - (w + h - lgcd);
        return answer;
    }

     public long gcd(long a, long b) {
        if (b == 0) {
            return (long)a;
        }
        return gcd(b, a%b);
    }
}
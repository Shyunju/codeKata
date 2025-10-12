using System;
public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if( a == b){
            return answer = a;
        }
        int min = Math.Min(a,b);
        int max = Math.Max(a,b);
        for ( int i = min; i <= max ; i++ ){
            answer += i;
        }
        return answer;
    }
}
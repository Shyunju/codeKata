using System;
using System.Collections.Generic;
public class Solution {
    public long solution(long n) {
        var num = new List<long>();
        while( n > 0){
            num.Add(n % 10);
            n /= 10;
        }
        num.Sort();
        num.Reverse();
        long answer = 0;
        
        for(int i = 0; i < num.Count; i++){
            answer += num[i];
            if( i != num.Count -1)
                answer *= 10;
        }
        return answer;
    }
}
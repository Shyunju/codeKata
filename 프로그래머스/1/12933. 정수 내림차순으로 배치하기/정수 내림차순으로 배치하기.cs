using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        List<int> list = new List<int>();
        while(n > 0)
        {
            list.Add((int)(n % 10));
            n /= 10;
        }
        list.Sort();
        list.Reverse();
        
        foreach(int i in list)
        {
            answer *= 10;
            answer += i;
        }
        return answer;
    }
}
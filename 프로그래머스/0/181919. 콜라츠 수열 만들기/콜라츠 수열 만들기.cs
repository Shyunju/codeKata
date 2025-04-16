using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        var answer = new List<int>();
        while(n != 1)
        {
            answer.Add(n);
            if(n % 2 == 0)
            {
                n /= 2;
            }else{
                n = 3 * n + 1;
            }
        }
        answer.Add(n);
        return answer.ToArray();
    }
}
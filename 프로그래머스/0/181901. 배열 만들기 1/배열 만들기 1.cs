using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int k) {
        var answer= new List<int>();
        for(int i = 1; i <= n; i++)
        {
            if(i % k == 0)
                answer.Add(i);
        }
        return answer.ToArray();
    }
}
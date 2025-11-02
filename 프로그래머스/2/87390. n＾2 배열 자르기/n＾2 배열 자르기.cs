using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, long left, long right) {
        List<int> answer = new List<int>();
        
        long idx = left;
        while(idx <= right)
        {
            int y = (int)(idx / n) + 1;
            int x = (int)(idx % n) + 1;
            answer.Add(Math.Max(y,x));
            idx++;
        }
        return answer.ToArray();
    }
}
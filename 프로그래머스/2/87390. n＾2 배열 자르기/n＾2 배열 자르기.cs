using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, long left, long right) {
        List<int> answer = new List<int>();
        while(left <= right)
        {
            int y = (int)(left / n) + 1;
            int x = (int)(left % n) + 1;
            answer.Add(Math.Max(y,x));
            left++;
        }
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        List<int> apples = new List<int>(score);
        apples.Sort();
        //apples.Reverse();
        int idx = apples.Count;
        while(idx >= m)
        {
            int min = apples[idx - m];
            answer += min * m;
            idx -= m;
        }
        return answer;
    }
}
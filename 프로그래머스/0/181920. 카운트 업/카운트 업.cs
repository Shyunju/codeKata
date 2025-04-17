using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int start_num, int end_num) {
        var answer = new List<int>();
        for(int i = start_num; i<= end_num; i++)
        {
            answer.Add(i);
        }
        return answer.ToArray();
    }
}
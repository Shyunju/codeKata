using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> answer = new List<int>();
        for(int i = n-1; i<num_list.Length; i++)
        {
            answer.Add(num_list[i]);
        }
        return answer.ToArray();
    }
}
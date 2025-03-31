using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list) {
        Array.Sort(num_list);
        var answer = new List<int>();
        for(int i = 5; i < num_list.Length; i++)
        {
            answer.Add(num_list[i]);
        }
        return answer.ToArray();
    }
}
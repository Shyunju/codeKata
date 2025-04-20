using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list) {
        var answer = new List<int>();
        foreach(int i in num_list)
        {
            answer.Add(i);
        }
        if(num_list[num_list.Length-1] > num_list[num_list.Length-2]){
            answer.Add(num_list[num_list.Length-1] - num_list[num_list.Length-2]);
        }else{
            answer.Add(num_list[num_list.Length-1]*2);
        }
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        var answer = new List<int>();
        foreach(int i in arr)
        {
            if(Array.IndexOf(delete_list, i) == -1 )
                answer.Add(i);
        }
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        var answer = new List<int>();
        int s = Array.IndexOf(arr, 2);
        int e = Array.LastIndexOf(arr, 2);
        if(s == -1 && e == -1)
        {
            answer.Add(-1);
        }else if(s == -1 || e == -1)
        {
            answer.Add(2);
        }else{
            for(int i = s; i <= e; i++)
            {
                answer.Add(arr[i]);
            }
        }
        
        return answer.ToArray();
    }
}
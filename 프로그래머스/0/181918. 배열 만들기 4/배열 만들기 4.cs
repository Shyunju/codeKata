using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        var stk = new List<int>();
        int i = 0;
        while(i < arr.Length)
        {
            if(stk.Count == 0)
            {
                stk.Add(arr[i]);
                i++;
            }else if(stk[stk.Count -1] < arr[i])
            {
                stk.Add(arr[i]);
                i++;
            }else if(stk[stk.Count-1] >= arr[i])
            {
                stk.RemoveAt(stk.Count-1);
            }
        }
        return stk.ToArray();
    }
}
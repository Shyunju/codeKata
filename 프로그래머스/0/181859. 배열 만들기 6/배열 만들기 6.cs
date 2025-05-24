using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        var stk = new List<int>();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(stk.Count == 0)
            {
                stk.Add(arr[i]);
                continue;
            }
            if(stk.Last() == arr[i])
            {
                stk.RemoveAt(stk.Count - 1);
            }else{
                stk.Add(arr[i]);
            }
        }
        if(stk.Count == 0)
            stk.Add(-1);
        return stk.ToArray();
    }
}
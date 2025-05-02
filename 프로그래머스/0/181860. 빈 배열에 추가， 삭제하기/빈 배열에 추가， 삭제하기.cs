using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        var x = new List<int>();
        for(int i = 0; i < flag.Length; i++)
        {
            if(flag[i])
            {
                for(int j = 0; j < arr[i] * 2; j++ ){
                    x.Add(arr[i]);
                }
                continue;
            }
            for(int j = 0; j < arr[i]; j++)
            {
                x.RemoveAt(x.Count -1);
            }
        }
        return x.ToArray();
    }
}
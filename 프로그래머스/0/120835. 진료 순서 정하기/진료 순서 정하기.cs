using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = (int[])emergency.Clone();
        Array.Sort(answer);
        Array.Reverse(answer);
        List<int> idx = new List<int>();
        
        for(int i = 0; i < answer.Length; i++)
        {
            idx.Add(Array.IndexOf(answer,emergency[i])+1);
        }
        return idx.ToArray();
    }
}
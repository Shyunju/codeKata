using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string before, string after) {
        int answer = 1;
        List<string> b_list = new List<string>();
        List<string> a_list = new List<string>();
        
        for(int i = 0; i < before.Length; i++)
        {
            b_list.Add(before[i].ToString());
            a_list.Add(after[i].ToString());
        }
        for(int i = 0; i < before.Length; i++)
        {
            if(a_list.Contains(b_list[i].ToString()))
            {
                a_list.Remove(b_list[i].ToString());
            }
        }
        return answer = a_list.Count == 0 ? 1 : 0;
    }
}
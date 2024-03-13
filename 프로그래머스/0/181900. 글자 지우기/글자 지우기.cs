using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string my_string, int[] indices) {
        List<char> result = new List<char>();
        for(int i = 0; i < my_string.Length; i++)
        {
            var check = Array.Exists(indices, x => x == i);
            if(check)
                continue;
            result.Add(my_string[i]);
        }
        string answer = string.Join("", result);
        return answer;
    }
}
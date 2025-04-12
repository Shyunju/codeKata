using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string my_string) {
        var answer = new List<string>();
        for(int i = 1; i < my_string.Length + 1; i++)
        {
            answer.Add(my_string.Substring(my_string.Length - i));
        }
        answer.Sort();
        return answer.ToArray();
    }
}
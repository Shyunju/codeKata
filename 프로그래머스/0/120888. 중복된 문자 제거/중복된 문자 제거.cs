using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        List<string> result = new List<string>();
        for(int i = 0; i < my_string.Length; i++)
        {
            result.Add(my_string[i].ToString());
        }
        result = result.Distinct().ToList();
        return answer = String.Join("", result);
    }
}
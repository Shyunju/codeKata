using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int age) {
        
        string[] num = {"a","b","c","d","e","f","g","h","i","j"};
        int idx = 0;
        List<string> age_string = new List<string>();
        while(age > 0)
        {
            idx = age % 10;
            age_string.Add(num. ElementAt(idx));
            age /= 10;
        }
        age_string.Reverse();
        string answer = string.Join("", age_string);
        return answer;
    }
}
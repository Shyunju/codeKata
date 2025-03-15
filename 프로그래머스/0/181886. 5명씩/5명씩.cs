using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] names) {
        List<string> answer = new List<string>();
        for(int i = 0; i < names.Length; i += 5){
            answer.Add(names[i]);
        }
        return answer.ToArray();
    }
}
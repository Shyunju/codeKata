using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] strArr) {
        var answer = new List<string>();
        foreach(string i in strArr)
        {
            if(!i.Contains("ad"))
                answer.Add(i);
        }
        return answer.ToArray();
    }
}
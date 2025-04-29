using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string myString) {
        string[] strArr = myString.Split('x');
        var answer = new List<string>();
        foreach(var i in strArr){
            if(i.Length > 0)
                answer.Add(i);
        }
        answer.Sort();
        return answer.ToArray();
    }
}
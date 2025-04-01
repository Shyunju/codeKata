using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string myString) {
        string[] splits = myString.Split('x');
        var answer = new List<int>();
        
        foreach(string i in splits)
        {
            answer.Add(i.Length);
        }
        return answer.ToArray();
    }
}
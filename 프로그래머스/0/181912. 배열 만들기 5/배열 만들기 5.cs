using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        var answer = new List<int>();
        foreach(string i in intStrs)
        {
            string str = i.Substring(s,l);
            int n = int.Parse(str);
            if(n > k)
                answer.Add(n);
        }
        return answer.ToArray();
    }
}
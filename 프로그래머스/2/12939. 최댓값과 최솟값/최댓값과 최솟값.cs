using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
        string[] numS = s.Split(" ");
        var num = new List<int>();
        foreach(string i in numS){
            int n = int.Parse(i);
            num.Add(n);
        }
        string answer = num.Min() + " " + num.Max();
        return answer;
    }
}
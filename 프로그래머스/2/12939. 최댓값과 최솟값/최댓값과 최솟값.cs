using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
        List<int> numl = new List<int>();
        string[] sl = s.Split(" "); 
        int num = 0;
        foreach(string i in sl)
        {
            if(int.TryParse(i, out num))
                numl.Add(num);
        }
        string answer = numl.Min().ToString() + " " + numl.Max().ToString();
        return answer;
    }
}
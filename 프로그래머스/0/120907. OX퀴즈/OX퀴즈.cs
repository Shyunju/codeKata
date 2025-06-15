using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] quiz) {
        var answer = new List<string>();
        foreach(string query in quiz)
        {
            string[] sl = query.Split();
            int x = int.Parse(sl[0]);
            int y = int.Parse(sl[2]);
            int z = int.Parse(sl[4]);
            switch(sl[1])
            {
                case "+":
                    answer.Add(x + y == z ? "O" : "X");
                    break;
                case "-":
                    answer.Add(x-y == z ? "O" : "X");
                    break;
                default:
                    break;
            }
        }
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] picture, int k) {
        var answer = new List<string>();
        for(int i = 0; i < picture.Length; i++)
        {
            string temp = "";
            foreach(char c in picture[i])
            {
                for(int j = 1; j <= k; j++)
                {
                    temp += c.ToString();
                }
            }
            for(int j = 1; j <= k; j++)
            {
                answer.Add(temp);
            }
        }
        return answer.ToArray();
    }
}
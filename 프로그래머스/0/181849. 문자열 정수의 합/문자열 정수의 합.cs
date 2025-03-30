using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        foreach(char i in num_str)
        {
            answer += int.Parse(i.ToString());
        }
        return answer;
    }
}
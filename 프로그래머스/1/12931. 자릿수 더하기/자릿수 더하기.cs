using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string num = n.ToString();
        foreach(char i in num)
        {
            answer += int.Parse(i.ToString());
        }
        return answer;
    }
}
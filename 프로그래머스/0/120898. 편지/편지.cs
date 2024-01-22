using System;

public class Solution {
    public int solution(string message) {
        char[] answer = new char[]{};
        answer = message.ToCharArray();
        return answer.Length * 2;
    }
}
using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = (B+B).IndexOf(A);
        return answer;
    }
}
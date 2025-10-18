using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        for(int i = 0; i < signs.Length; i++)
        {
            answer += signs[i] ? absolutes[i] : -1 * absolutes[i];
        }
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int n = m -1;
        Array.Sort(score);
        Array.Reverse(score);
        for(int i =0 ; i < score.Length / m; i++){
            answer += score[n] * m;
            n += m;

        }
        return answer;
    }
}
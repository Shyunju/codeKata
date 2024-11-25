using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int all = score.Length;
        Array.Sort(score);
        Array.Reverse(score);
        int answer = 0;
        for(int i = m-1; i < all; i += m){
            answer += score[i] * m;
        }
        return answer;
    }
}
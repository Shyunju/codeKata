using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int sum = 0;
        for(int i = 0; i < signs.Length; i++){
            sum += signs[i] ? absolutes[i] : -absolutes[i];
        }
        return sum;
    }
}
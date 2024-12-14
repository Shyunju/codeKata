using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int sum = 0;
        for(int i = 0; i < signs.Length; i++){
            if(!signs[i])
                absolutes[i] *= -1;
            sum += absolutes[i];
        }
        return sum;
    }
}
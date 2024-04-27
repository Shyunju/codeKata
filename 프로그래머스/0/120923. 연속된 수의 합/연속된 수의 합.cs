using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int plus = num * (num +1) / 2;
        int result = (total - plus) / num;
        for(int i = 0; i <num; i++)
        {
            answer[i] = (i + 1) + result;
        }
        return answer;
    }
}
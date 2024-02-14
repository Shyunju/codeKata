using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[(n + 1) / 2];
        for (int i = 0; i < (n + 1) / 2; i++)
            answer[i] = (i << 1) + 1;
        return answer;
    }
}
using System;

public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];
        Array.Clear(answer, 0, answer.Length);

        for(int i=0; i<prices.Length; i++) {
            for(int j=i+1; j<prices.Length; j++) {
                answer[i]++;
                if (prices[i] > prices[j])
                    break;
            }
        }
        return answer;
    }
}
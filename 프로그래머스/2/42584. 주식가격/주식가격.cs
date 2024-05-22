using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];
        for(int i=0; i<prices.Length-1; i++)
        {
            for(int j=i+1; j<prices.Length; j++)
            {
                if(prices[i]>prices[j])
                {
                    answer[i] = j-i;
                    break;
                }
                answer[i] = prices.Length-1- i;
            }
        }
        return answer;
    }
}
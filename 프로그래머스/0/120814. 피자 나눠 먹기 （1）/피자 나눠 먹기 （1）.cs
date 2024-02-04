using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        int pizza = 7;
        while(pizza < n)
        {
            answer++;
            pizza += 7;
        }
            
        return answer;
    }
}
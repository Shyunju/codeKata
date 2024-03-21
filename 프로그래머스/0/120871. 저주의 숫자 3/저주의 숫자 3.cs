using System;

public class Solution {
    public int solution(int n) {
        int[] answer = new int[101];
        int num = 1;
        for(int i= 1; i <= 100; i++)
        {
            while(answer[i] == 0)
            {
                if(num % 3 == 0 || num.ToString().Contains("3"))
                {
                    num++;
                    continue;
                }
                answer[i] = num;
                num++;
            }
            
        }
        return answer[n];
    }
}
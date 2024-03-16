using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        foreach(int i in num_list)
        {
            if(i % 2 == 0)
                answer[0]++;
            else
                answer[1]++;
        }
        return answer;
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] days = new int[speeds.Length];
        List<int> answer = new List<int>();
        int count = 1;
        
        for(int i = 0; i < days.Length; i++)
        {
            days[i] = (100 - progresses[i]) / speeds[i];
            if((100 - progresses[i]) % speeds[i] != 0)
                days[i]++;
        }
        int day = days[0];
        for(int i = 1; i < days.Length; i++)
        {
            if(day < days[i])
            {
                answer.Add(count);
                count = 1;
                day = days[i];
            }else{
                count++;
                continue;
            }
        }
        answer.Add(count);
        
        return answer.ToArray();
    }
}
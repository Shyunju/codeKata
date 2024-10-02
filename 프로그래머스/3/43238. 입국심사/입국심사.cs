using System;

public class Solution {
    public long solution(int n, int[] times) {
        
        Array.Sort(times);
        long maxTime = (long)n * times[times.Length -1];
        long minTime = 1;
        long answer = maxTime;
        
        while(minTime <= maxTime){
            long midTime = (maxTime + minTime) / 2;
            long total = 0;
            
            foreach(int i in times){
                total += midTime / i;
            }
            if(total < n) minTime = midTime + 1;
            else{
                maxTime = midTime-1;
                answer = Math.Min(answer, midTime);
            }
        }
        return answer;
    }
}
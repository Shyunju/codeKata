using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] jobs) {
        var jobQ = new Queue<(int requestTime, int duration)>(
            Enumerable.Range(0, jobs.GetLength(0))
            .Select(s => (jobs[s,0], jobs[s,1]))
            .OrderBy(o => o.Item1));
        
        int time = 0;
        int curRequestTime = 0;
        int curDuration = 0;
        int total = 0;
        
        var jobCanStart = new List<(int requestTime, int duration)>();
        
        while(jobQ.Count > 0 || jobCanStart.Count>0 || curDuration > 0){
            if(curDuration > 0){
                --curDuration;
                ++time;
                if(curDuration == 0)
                    total += time - curRequestTime;
                continue;
            }
            while(jobQ.Count > 0 && jobQ.Peek().Item1 <= time)
                jobCanStart.Add(jobQ.Dequeue());
            if(jobCanStart.Count == 0){
                ++time;
                continue;
            }
            (int requestTime, int duration) cur = jobCanStart.OrderBy(o => o.Item2).First();
            jobCanStart.Remove(cur);
            
            curRequestTime = cur.requestTime;
            curDuration = cur.duration;
        }
        return total / jobs.GetLength(0);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[,] jobs) 
{
    var jobQueue = new Queue<(int requestTime, int duration)>(
        Enumerable.Range(0, jobs.GetLength(0))
            .Select(e => (jobs[e, 0], jobs[e, 1]))
            .OrderBy(e => e.Item1)
    );

    int time = 0;
    int curRequestTime = 0;
    int curRemain = 0;
    int completeTimeSum = 0;

    var jobCanStart = new List<(int requestTime, int duration)>();
    while(jobQueue.Count > 0 || jobCanStart.Count > 0 || curRemain > 0)
    {
        if(curRemain > 0)
        {
            --curRemain;
            ++time;

            if(curRemain == 0) // 완료함
                completeTimeSum += time - curRequestTime;    

            continue;
        }

        while(jobQueue.Count > 0 && jobQueue.Peek().Item1 <= time)
            jobCanStart.Add(jobQueue.Dequeue());

        if(jobCanStart.Count == 0) // 실행할 수 있는 작업이 없음
        {
            ++time;
            continue;
        }

        (int requestTime, int duration) cur = jobCanStart.OrderBy(e => e.Item2).First();
        jobCanStart.Remove(cur);

        curRequestTime = cur.requestTime;
        curRemain = cur.duration;
    }

    return completeTimeSum / jobs.GetLength(0);
}

}
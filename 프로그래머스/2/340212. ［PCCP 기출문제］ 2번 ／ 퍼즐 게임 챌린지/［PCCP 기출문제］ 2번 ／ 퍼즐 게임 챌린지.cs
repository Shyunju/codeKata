using System;
using System.Linq;
public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int left = 1;
        int right = diffs.Max();
        int answer = right;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            long used_time = Resolve(diffs, times, mid);
            if (used_time <= limit) {
                answer = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return answer;            
    }
    long Resolve(int[] diffs, int[] times, int level)
    {
        long used_time = 0;
        for(int i = 0; i < diffs.Length; i++)
        {
            if(diffs[i] <= level)
            {
                used_time += times[i];
                continue;
            }else{
                int gap = diffs[i] - level;
                used_time += gap * (times[i] + times[i-1]) + times[i];
            }
        }
        return used_time;
    }
}
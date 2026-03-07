using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public long solution(int n, int[] works) {
        long answer = 0;
        List<int> list = new List<int>(works);
        list.Sort();
        list.Reverse();
        if(list.Sum() <= n) return answer;
        int max = 0;
        int idx = 0;
        while( n > 0)
        {
            if(list[idx] >= list[max])
            {
                list[idx]--;
                n--;
            }
            if(list[idx] > list[max])
            {
                max = idx;
            }
            if(idx < list.Count-1)
            {
                idx++;
            }
            else
            {
                idx = 0;
            }
        }
        foreach(int i in list)
        {
            answer += (long)(i*i);
        }
        return answer;
    }
}
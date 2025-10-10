using System;
using System.Collections.Generic;
using System.Linq; 
public class Solution {
    public int solution(int k, int[] tangerine) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int answer = 0;
        foreach(int i in tangerine)
        {
            if(!dic.ContainsKey(i))
                dic.Add(i, 0);
            dic[i]++;
        }
        List<int> count = new List<int>(dic.Values);
        count.Sort();
        count.Reverse();
        while(k > 0)
        {
            k -= count[0];
            answer++;
            count.RemoveAt(0);
        }
        return answer;
    }
}
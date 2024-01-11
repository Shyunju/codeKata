using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        
        Dictionary<int, int> size = new Dictionary<int, int>();
        foreach(int i in tangerine)
        {
            if(!size.ContainsKey(i))
                size.Add(i, 1);
            else
                size[i]++;
        }
        
        List<int> count = new List<int>(size.Values);
        count.Sort();
        
        int kCount = 0;
        int kIndex = count.Count - 1;
        
        while(k>kCount)
        {
            kCount += count[kIndex--];
            answer++;
        }
        return answer;
    }
}

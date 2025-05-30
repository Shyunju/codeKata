using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int k) {
        var hs = new HashSet<int>();
        foreach(int i in arr)
        {
            hs.Add(i);
            if(hs.Count == k)
                return hs.ToArray();
        }
        var answer = new List<int>();
        answer = hs.ToList();
        while(answer.Count < k)
        {
            answer.Add(-1);
        }
        return answer.ToArray();
    }
}
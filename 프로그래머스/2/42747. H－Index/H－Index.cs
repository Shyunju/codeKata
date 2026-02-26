using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
        int answer = 0;
        for(int i = 0; i < citations.Length; i++)
        {
            if((i+1) <= citations[i]) answer++;
        }
        return answer;
    }
}
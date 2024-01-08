using System;
using static System.Math;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        while(true)
        {
            if(n==0) break;
            int d = n%3;
            list.Add(d);
            n = n/3;
        }
        list.Reverse();
        
        for(int i = 0; i<list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3,i));
        }
        return answer;
    }
   
}
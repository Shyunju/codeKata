using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<(int, int)> q = new Queue<(int, int)>();
        List<int> grade = new List<int>();
        for(int i = 0; i < priorities.Length; i++)
        {
            q.Enqueue((i, priorities[i]));
        }
        Array.Sort(priorities);
        Array.Reverse(priorities);
        grade = priorities.ToList();
        while(q.Count != 0)
        {
            (int a, int b) = q.Dequeue();
            
            if( b == grade.First())
            {
                answer++;
                
                if( a == location)
                    return answer;
                
                grade.RemoveAt(0);
                continue;
            }
            q.Enqueue((a,b));
            
        }
        return answer;
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[,] roads, int[] sources, int destination) {
        int[] answer = new int[sources.Length];
        var q = new Queue<(int, int)>();
        var dict = new Dictionary<int, List<int>>();
        bool[] visit = new bool[n+1];
        
        for(int i = 0; i < answer.Length; i++)
            answer[i] = -1;
        
        for(int i = 0; i <= n; i++){
            dict.Add(i, new List<int>());
        }
        for(int i = 0; i < roads.GetLength(0); i++){
            dict[roads[i,0]].Add(roads[i,1]);
            dict[roads[i,1]].Add(roads[i,0]);
        }
        
        q.Enqueue((destination, 0));
        visit[destination] = true;
        
        while(q.Count > 0){
            (int now, int count) = q.Dequeue();
            for(int i= 0; i < dict[now].Count; i++){
                if(visit[dict[now][i]]) continue;
                visit[dict[now][i]] = true;
                q.Enqueue((dict[now][i], count+1));
            }
            for(int i = 0; i < sources.Length; i++){
                if(now == sources[i]) answer[i] = count;
            }
        }
        return answer;
    }
}
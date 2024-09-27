using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[,] edge) {
        int answer = 0;
        int[] visited = new int[n+1];
        int[,] graph = new int[n+1, n+1];
        for(int i = 0; i < edge.GetLength(0); i++){
            graph[edge[i,0], edge[i,1]] = 1;
            graph[edge[i,1], edge[i,0]] = 1;
        }
        int[] dist = new int[n+1];
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        q.Enqueue(new Tuple<int, int>(0,1));
        for(int i = 2; i < n+1; i++){
            dist[i] = 50001;
        }
        while(q.Count > 0){
            Tuple<int, int> t = q.Dequeue();
            dist[t.Item2] = dist[t.Item2] > dist[t.Item1] + 1 ? dist[t.Item1] + 1 : dist[t.Item2];
            
            for(int i = 1; i < n+1; i++){
                if(visited[i] == 0 && graph[t.Item2, i] == 1){
                    q.Enqueue(new Tuple<int, int>(t.Item2, i));
                    visited[i] = 1;
                }
            }
        }
        for(int i = 0; i < dist.Length; i++){
            if(dist[i] == dist.Max())   answer++;
        }
        return answer;
    }
}
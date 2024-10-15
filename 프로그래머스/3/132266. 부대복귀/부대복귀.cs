using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[,] roads, int[] sources, int destination) {
        int[] answer = new int[sources.Length];
        
        List<int>[] graph = new List<int>[n+1];
        // graph 초기화
        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }
        for (int i = 0; i < roads.GetLength(0); i++)
        {
            int road1 = roads[i, 0];
            int road2 = roads[i, 1];
            graph[road1].Add(road2);
            graph[road2].Add(road1);
        }
        
        int[] distFromDest = Enumerable.Repeat(100001, n+1).ToArray();
        // dest 기준 BFS로 dist 구하기
        // node Num, curr Dist
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((destination, 0));
        bool[] visited = new bool[n + 1];
        visited[destination] = true;
        distFromDest[destination] = 0;
        
        while (queue.Count >= 1)
        {
            (int currNode, int dist) = queue.Dequeue();
            distFromDest[currNode] = Math.Min(dist, distFromDest[currNode]);
            visited[currNode] = true;
            
            foreach(int adjNode in graph[currNode])
            {
                if (visited[adjNode]) continue;
                queue.Enqueue((adjNode, dist + 1));
            }   
        }
        
        for (int i = 0; i < sources.Length; i++)
        {
            int source = sources[i];
            
            if (graph[source].Count == 0) 
            {
                answer[i] = -1;
                continue;
            }
            
            if (distFromDest[source] == 100001)
            {
                answer[i] = -1;
                continue;
            }
            
            answer[i] = distFromDest[source];
        }
        
        
        return answer;
    }
}
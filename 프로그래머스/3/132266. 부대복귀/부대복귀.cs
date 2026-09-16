using System;
using System.Collections.Generic;

public class Solution {
    public class Edge
    {
        public int To {get; set;}
        public int Weight {get; set;}
        
        public Edge(int to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }
    public int[] solution(int n, int[,] roads, int[] sources, int destination) {
        int[] answer = new int[sources.Length];
        int[] distance = new int[n+1];
        List<Edge>[] graph = new List<Edge>[n+1];
        for(int i =0; i< n+1; i++)
        {
            graph[i] = new List<Edge>();
        }
        for(int i = 0; i < roads.GetLength(0); i++)
        {
            graph[roads[i,0]].Add(new Edge(roads[i,1], 1));
            graph[roads[i,1]].Add(new Edge(roads[i,0], 1));
        }
        distance = Dijkstra(graph, destination, n);
        for(int i = 0; i < answer.Length; i++)
        {
            
            answer[i] = distance[sources[i]] == int.MaxValue ? -1: distance[sources[i]];
        }
        
        return answer;
    }
    public int[] Dijkstra(List<Edge>[] graph, int start, int n)
    {
        int[] dis = new int[n+1];
        Array.Fill(dis, int.MaxValue);
        
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(start, 0);
        dis[start] = 0;
        
        while(pq.Count > 0)
        {
            pq.TryDequeue(out int curNode, out int curDist);
            if(dis[curNode] < curDist) continue;
            
            foreach(var edge in graph[curNode])
            {
                int nextNode = edge.To;
                int nextDist = edge.Weight + curDist;
                
                if(dis[nextNode] > nextDist)
                {
                    dis[nextNode] = nextDist;
                    pq.Enqueue(nextNode, nextDist);
                }
            }
        }
        return dis;
    }
}
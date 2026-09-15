using System;
using System.Linq;
using System.Collections.Generic;
class Solution
{
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
    public int solution(int N, int[,] road, int K)
    {
        int[] distance = new int[N + 1];
        List<Edge>[] graph = new List<Edge>[N+1];
        for(int i =1; i < N+1; i++)
        {
            graph[i] = new List<Edge>();
        }
        for(int i =0; i < road.GetLength(0); i++)
        {
            graph[road[i,0]].Add(new Edge(road[i,1], road[i,2]));
            graph[road[i,1]].Add(new Edge(road[i,0], road[i,2]));
        }
        
        distance = Dijkstra(graph, 1, N);
        return distance.Count(c => c <= K);
        
    }
    public int[] Dijkstra(List<Edge>[] graph, int startNode, int nodeCnt)
    {
        int[] dis = new int[nodeCnt + 1];
        Array.Fill(dis, int.MaxValue);
        
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(startNode, 0);
        dis[startNode] = 0;
        
        while(pq.Count > 0)
        {
            pq.TryDequeue(out int curNode, out int curDist);
            if(dis[curNode] < curDist)  continue;
            
            foreach(var edge in graph[curNode])
            {
                int nextNode = edge.To;
                int nextDist = curDist + edge.Weight;
                
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
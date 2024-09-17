using System;
using System.Collections.Generic;

public class Solution {
    long answer = 0;
    long[] longA;
    public long solution(int[] a, int[,] edges) {
        long sum = 0;
        int n = a.Length;
        
        longA = new long[n];
        List<long>[] graph = new List<long>[n];
        for (int i = 0; i < n; i++)
        {
            sum += a[i];
            longA[i] = (long)a[i];
            graph[i] = new List<long>();
        }
        
        if (sum != 0) return -1; // 전체 가중치 합을 0으로 못 만드는 경우
        
        // 인접 리스트 초기화
        for (int i = 0; i < edges.GetLength(0); i++)
        {
            long firstNode = (long)edges[i, 0];
            long secondNode = (long)edges[i, 1];
            graph[firstNode].Add(secondNode);
            graph[secondNode].Add(firstNode);
        }
        
        bool[] visited = new bool[n]; 
        DFS(0, 0, graph, visited);
        return answer;
    }
    
    public void DFS(long currNode, long parentNode, List<long>[] graph, bool[] visited)
    {   
        visited[currNode] = true;
        
        foreach(int adjNode in graph[currNode])
        {
            if (!visited[adjNode])
            {
                DFS(adjNode, currNode, graph, visited);
            }
        }
        
        answer += (long)Math.Abs(longA[currNode]);
        longA[parentNode] += longA[currNode];
        longA[currNode] = 0;
    }
}
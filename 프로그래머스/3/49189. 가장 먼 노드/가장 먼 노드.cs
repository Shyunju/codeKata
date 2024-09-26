using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[,] edge) {
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
            int[] visited = new int[n+1];
            queue.Enqueue(new Tuple<int,int>(0,1));
            visited[1]=1;
            int[,] graph= new int[n+1,n+1];
            for (int i = 0; i < edge.GetLength(0); i++)
            {
                graph[edge[i, 0], edge[i, 1]] = 1;
                graph[edge[i, 1], edge[i, 0]] = 1;
            }
            int answer = 0;
            int[] distance = new int[n+1];
            for (int i = 2; i < distance.Length;i++)
                distance[i] = 50001;
            while (queue.Count > 0)
            {
                Tuple<int,int> t = queue.Dequeue();
                distance[t.Item2] = distance[t.Item2] > distance[t.Item1] + 1 ? distance[t.Item1] + 1 : distance[t.Item2];
                for (int i = 1; i < n + 1; i++)
                {
                    if (visited[i]!=1 && graph[t.Item2, i] == 1)
                    {
                        queue.Enqueue(new Tuple<int,int>(t.Item2,i));
                        visited[i]=1;
                    }
                }
            }
            for (int i = 0; i < distance.Length; i++)
            {
                if (distance[i] == distance.Max())
                    answer++;
            }
                return answer;
    }
}
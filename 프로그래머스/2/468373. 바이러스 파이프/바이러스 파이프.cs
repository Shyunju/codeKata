using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<List<(int,int)>> pipes = new List<List<(int, int)>>();
    public int solution(int n, int infection, int[,] edges, int k) {
        int answer = 0;
        // 노드 개수만큼의 방문(감염)배열 만들고
        bool[] visited = new bool[n+1];
        visited[infection] = true;
        //타입별로 연결 튜플 리스트 만들고
        List<(int, int)> typeA = new List<(int, int)>();
        List<(int, int)> typeB = new List<(int, int)>();
        List<(int, int)> typeC = new List<(int, int)>();
        
        
        
        for(int i = 0; i < edges.GetLength(0); i++)
        {
            int type = edges[i,2];
            switch(type)
            {
                case 1:
                    typeA.Add((edges[i,0], edges[i,1]));
                    break;
                case 2:
                    typeB.Add((edges[i,0], edges[i,1]));
                    break;
                case 3:
                    typeC.Add((edges[i,0], edges[i,1]));
                    break;
            }
        }
        pipes.Add(typeA);
        pipes.Add(typeB);
        pipes.Add(typeC);
        
        for(int i = 0; i < 3; i++)
        {
            DFS(0, visited, ref answer, k);
        }
        return answer;
    }
    public void DFS(int turn, bool[] visited, ref int answer, int k)
    {
        if(turn >= k)
        {
            int result = visited.Count(v => v);
            answer = Math.Max(result, answer);
            return;
        }
        
        
        for(int i = 0; i < 3; i++)
        {
            List<int> reback = new List<int>();
            bool update = true;
            while(update)
            {
                update = false;

                foreach(var item in pipes[i])
                {
                    if(visited[item.Item1] && !visited[item.Item2])
                    {
                        visited[item.Item2] = true;
                        reback.Add(item.Item2);
                        update = true;
                    }
                    else if(!visited[item.Item1] && visited[item.Item2])
                    {
                        visited[item.Item1] = true;
                        reback.Add(item.Item1);
                        update = true;
                    }
                }
            }
            DFS(turn+1, visited, ref answer, k);

            foreach(int idx in reback)
            {
                visited[idx] = false;
            }
        }
    }
    
}
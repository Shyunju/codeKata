using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    bool[] visited;
    int[,] edges;
    int[] info;
    HashSet<int> sheepCounts;
    public int solution(int[] info, int[,] edges) {
        this.info = info;
        this.edges = edges;
        sheepCounts = new HashSet<int>();
        visited = new bool[info.Length];
        
        visited[0] = true;
        DFS(1, 0);
        
        return sheepCounts.Max();
    }
    
    private void DFS(int sheep, int wolf)
    {  
        if (wolf >= sheep) return; // wolf가 많아지는 경우 그 뒤 sheep 만나면 무조건 먹히므로 pass
        sheepCounts.Add(sheep); // 현재 sheep count 저장
        
        for (int i = 0; i < edges.GetLength(0); i++)
        {
            int parent = edges[i, 0];
            int child = edges[i, 1];
            int wolfCount = info[child];
            // 부모 방문하고 아직 자식 방문 안한 경우에 대한 케이스 모두 확인
            if (visited[parent] && visited[child] == false)
            {
                visited[child] = true;
                DFS(sheep + 1 - wolfCount, wolf + wolfCount); // dfs로 돈 다음
                visited[child] = false; // 방문 표시 빼기 
            }
        }
        
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    bool[] visited;
    int[] info;
    int[,] edges;
    HashSet<int> sheepCnt;
    public int solution(int[] info, int[,] edges) {
        this.info = info;
        this.edges = edges;
        visited = new bool[info.Length];
        sheepCnt = new HashSet<int>();
        
        visited[0] = true;
        DFS(1,0);
        
        return sheepCnt.Max();
    }
    private void DFS(int sheep, int wolf){
        if(wolf >= sheep) return;
        
        sheepCnt.Add(sheep);
        
        for(int i = 0; i < edges.GetLength(0); i++){
            
            int parent = edges[i,0];
            int child = edges[i,1];
            int plusWolf = info[child];
            
            if(visited[parent] && !visited[child]){
                visited[child] = true;
                DFS(sheep + 1 - plusWolf, wolf + plusWolf);
                visited[child] = false;
            }
        }
    }
}
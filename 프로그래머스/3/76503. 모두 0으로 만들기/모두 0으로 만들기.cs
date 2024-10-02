using System;
using System.Collections.Generic;
public class Solution {
    public long solution(int[] a, int[,] edges) {
        long answer = 0;
        var dict = new Dictionary<int, List<int>>();
        long[] nodeArr = new long[a.Length];
        bool[] visited = new bool[a.Length];
        
        long total = 0;
        for(int i = 0; i< a.Length; i++){
            dict.Add(i, new List<int>());
            nodeArr[i] = (long)a[i];
            total += (long)a[i];
        }
        if( total != 0)  return -1;
        
        for(int i =0; i< edges.GetLength(0); i++){
            dict[edges[i,0]].Add(edges[i,1]);
            dict[edges[i,1]].Add(edges[i,0]);
        }
        
        DFS(0, 0, nodeArr, visited, dict, ref answer);
        return answer;
    }
    private void DFS(int curr, int parent, long[] nodeArr, bool[] visited, Dictionary<int, List<int>> dict, ref long answer){
        foreach(int child in dict[curr]){
            visited[curr] = true;
            if(!visited[child])
                DFS(child, curr, nodeArr, visited, dict, ref answer);
        }
        answer += Math.Abs(nodeArr[curr]);
        nodeArr[parent] += nodeArr[curr];
    }
}
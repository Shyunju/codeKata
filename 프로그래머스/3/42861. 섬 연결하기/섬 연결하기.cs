using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] costs) {
        int answer = 0;
        int [,] dist = new int[n,n];
        for(int i = 0; i < n; i++){
            for( int j = 0; j < n; j++){
                dist[i,j] = -1;
            }
        }
        for(int i = 0; i < costs.GetLength(0); i++){
            dist[costs[i,0], costs[i,1]] = costs[i,2];
            dist[costs[i,1], costs[i,0]] = costs[i,2];
        }
        int min;
        int minIdx = -1;
        HashSet<int> visit = new HashSet<int>();
        visit.Add(0);
        while(visit.Count < n){
            min = int.MaxValue;
            foreach(int node in visit){
                for(int i = 0; i < n; i++){
                    if(visit.Contains(i)) continue;
                    if(dist[node, i] != -1 && dist[node, i] < min){
                        min = dist[node, i];
                        minIdx = i;
                    }
                }
            }
            answer += min;
            visit.Add(minIdx);
        }
        return answer;
    }
}
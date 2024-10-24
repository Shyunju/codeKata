using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    static int[] dist = new int[50001];
    static List<List<int>>[] node = new List<List<int>>[50001];
    static bool[] isTop = new bool[50001];
    static int[] answer = new int[2]{-1, -1};
    
    public class MyCompare : IComparer<List<int>>
    {
        public int Compare(List<int> x, List<int> y){
            if(x[0] == y[0])
                return y[1]-x[1];
            return y[0]-x[0];
        }
    }
    public void Dijkstra(int[] gates){
        SortedSet<List<int>> q = new SortedSet<List<int>>(new MyCompare());
        
        foreach(int gate in gates){
            q.Add(new List<int>() {0, gate});
            dist[gate] = 0;
        }
        while(q.Count > 0){
            List<int> cnt = q.First();
            q.Remove(cnt);
            int x = cnt[1];
            int cost = cnt[0];
            
            if(cost > dist[x]) continue;
            if(answer[0] != -1 && answer[1] < cost) continue;
            
            if(isTop[x]){
                if(answer[0] == -1 || answer[1] > cost){
                    answer[0] =x;
                    answer[1] = cost;
                }else if(answer[1] == cost && answer[0] > x) answer[0] = x;
                continue;
            }
            for(int i = 0; i < node[x].Count; i++){
                int next = node[x][i][0];
                int nCost = node[x][i][1];
                
                if(dist[next] == -1 || Math.Max(cost, nCost) < dist[next]){
                    dist[next] = Math.Max(cost, nCost);
                    q.Add(new List<int>(){dist[next], next});
                }
            }
        }
    }
    public int[] solution(int n, int[,] paths, int[] gates, int[] summits) {
        Array.Fill(dist, -1);
        for(int i = 0; i <= n; i++){
            node[i] = new List<List<int>>();
        }
        foreach(int summit in summits)
            isTop[summit] = true;
        
        for(int i = 0; i < paths.GetLength(0); i++){
            int n1 = paths[i, 0];
            int n2 = paths[i, 1];
            int cost = paths[i, 2];

            node[n1].Add(new List<int>() { n2, cost });
            node[n2].Add(new List<int>() { n1, cost });
        }
        Dijkstra(gates);
        return answer;
    }
}
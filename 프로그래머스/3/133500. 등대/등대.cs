using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n, int[,] lighthouse) {
        int answer = 0;
        bool[] isLightOn = new bool[n+1];
        var info = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < n+1; i++){
            info.Add(i, new List<int>());
        }
        for(int i = 0; i < lighthouse.GetLength(0); i++){
            info[lighthouse[i,0]].Add(lighthouse[i,1]);
            info[lighthouse[i,1]].Add(lighthouse[i,0]);
        }
        dfs(1, 1, info, isLightOn, ref answer);
        return answer;
    }
    private void dfs(int node, int parent, Dictionary<int, List<int>> info, bool[] isLightOn, ref int answer){
        for(int i = 0; i < info[node].Count; i++){
            if(info[node][i] != parent){
                dfs(info[node][i], node, info, isLightOn, ref answer);
                
                if(!isLightOn[info[node][i]] && !isLightOn[node]){
                    isLightOn[node] = true;
                    answer++;
                }
            }
        }
    }
}
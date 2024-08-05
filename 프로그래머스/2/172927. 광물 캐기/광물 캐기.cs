using System;

public class Solution {
    public int solution(int[] picks, string[] minerals) {
        int answer = int.MaxValue;
        int[,] pickCost = new int[3,3] { {1, 1, 1}, { 5, 1, 1}, {25, 5, 1}};
        int [] mineralIdx = new int[minerals.Length];
        for(int i = 0; i < minerals.Length; i++){
            switch(minerals[i]){
                case "diamond" : mineralIdx[i] = 0; break;
                case "iron" : mineralIdx[i] = 1; break;
                case "stone" : mineralIdx[i] = 2; break;
            }
        }
        dfs(picks, mineralIdx, pickCost, 0, 0, ref answer);
        return answer;
    }
    public void dfs(int[] picks, int[] mineralIdx, int[,] pickCost, int n, int fatigue, ref int answer){
        const int MAX = 5;
        if ( n >= mineralIdx.Length){
            if(fatigue < answer)
                answer = fatigue;
        }
        bool empty = true;
        for(int i = 0; i < 3; i++){
            if(picks[i] == 0) continue;
            empty = false;
            
            int curFatigue = 0;
            for(int k = 0; k < MAX; k++){
                if(n + k >= mineralIdx.Length) break;
                
                int curMineral = mineralIdx[n+k];
                curFatigue += pickCost[i, curMineral];
            }
            --picks[i];
            dfs(picks, mineralIdx, pickCost, n+MAX, fatigue + curFatigue, ref answer);
            ++picks[i];
        }
        if(empty){
            if(fatigue < answer)
                answer = fatigue;
        }
    }
}
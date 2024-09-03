using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string begin, string target, string[] words) {
        if(Array.IndexOf(words, target) == -1) return 0;
        int answer = int.MaxValue;
        
        bool[] visit = new bool[words.Length];
        dfs(0, begin, target, words, visit, ref answer);
        
        return answer == int.MaxValue ? 0 : answer;
    }
    
    private void dfs(int n, string cur, string target, string[] words, bool[] visit, ref int answer){
        
        if(cur == target){
            if(n < answer) answer = n;
            return;
        }
        
        for(int i = 0; i < words.Length; i++){
            if(visit[i]) continue;
            if(DiffCount(cur, words[i]) != 1) continue;
            
            visit[i] = true;
            dfs(n+1, words[i], target, words, visit, ref answer);
            visit[i] = false;
        }
    }
    private int DiffCount(string a, string b){
        return Enumerable.Range(0, a.Length).Count( c => a[c] != b[c]);
    }
}
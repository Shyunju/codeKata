using System;
using System.Linq;
public class Solution {
    int maxVal = 0, minScore = 11;
    bool[] maxState;
    public int[] solution(int n, int[] info) {
        int[] answer = new int[11];
        int[] need = info.Select(s => s + 1).ToArray();
        bool[] state = new bool[11];
        dfs(10, 0, 0, n, need, state, info, 11);
        int apeachScore = 0;
        
        for(int i = 0; i < 10; i++){
            if(maxState[i]){
                answer[i] = need[i];
                n -= need[i];
            }
            if(info[i] > 0) apeachScore += 10 - i;
        }
        answer[10] = n;
        return maxVal > apeachScore ? answer : new int[1] {-1};
    }
    public void dfs(int score, int sum, int cnt, int n, int[] need, bool[] state, int[] info, int lastAdd){
        if(cnt > n || score == 0) return;
        
        if(maxVal < sum || (maxVal == sum && lastAdd < minScore)){
            maxVal = sum;
            minScore = lastAdd;
            maxState = (bool[])state.Clone();
        }
        dfs(score -1, sum, cnt, n, need, state, info, lastAdd);
        state[10 - score] = true;
        dfs(score -1, sum + score * (info[10 - score] > 0 ? 2 : 1), cnt + need[10-score], n, need, state, info, score);
        state[10-score] = false;
    }
}
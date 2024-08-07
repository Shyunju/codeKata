using System;

public class Solution {
    public int[] answer;
    public int[] ryan_info;
    public int[] apeach_info;
    public int maxDiff = -1;
    public int[] solution(int n, int[] info) {
        apeach_info = info;
        ryan_info = new int[11];
        answer = new int[11];
        dfs(n, 0, 0, 0);
        
        return maxDiff != -1 ? answer : new int[1] {-1};
    }
    private void dfs(int left, int ryanScore, int apeachScore, int idx){
        
        if(idx == 11){
            ryan_info[10] = left;
        
            int diff = ryanScore - apeachScore;
            if(apeachScore < ryanScore && maxDiff <= diff){
                
                if(maxDiff == diff && !isLowerArr(ryan_info)) 
                    return;
                
                maxDiff = diff;
                answer = (int[])ryan_info.Clone();
            }
            return;
        }
        
        int need = apeach_info[idx] +1;
        if(need <= left){
            ryan_info[idx] = need;
            dfs(left-need, ryanScore + (10 - idx), apeachScore, idx +1);
            ryan_info[idx] = 0;
        }
        
        if(apeach_info[idx] != 0)
            dfs(left, ryanScore, apeachScore + (10 - idx), idx +1);
        else
            dfs(left, ryanScore, apeachScore, idx + 1);
    }
    
    private bool isLowerArr(int[] new_arr){
        for(int i = 9; i >= 0; i--){
            if(answer[i] == new_arr[i]) continue;
            if(answer[i] < new_arr[i]) return true;
            break;
        }
        return false;
    }
}

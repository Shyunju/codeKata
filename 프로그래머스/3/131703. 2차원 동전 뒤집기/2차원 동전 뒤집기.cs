using System;

public class Solution {
    public int solution(int[,] begin, int[,] target) {
        int answer = -1;
        
        var intArr = new int[target.GetLength(0), target.GetLength(1)];
        for(int i = 0; i <target.GetLength(0); i++){
            for(int j = 0; j< target.GetLength(1); j++){
                intArr[i,j] = (begin[i, j] == target[i,j]) ? 1 : -1;
            }
        }
        dfs(0, 0, intArr, ref answer);
        return answer;
    }
    private void dfs(int cur, int count, int[,] intArr, ref int answer){
        int idx = cur;
        if(idx == intArr.GetLength(0) + intArr.GetLength(1)){
            foreach(int n in intArr)
                if(n == -1) return;
            if(answer == -1) answer = count;
            else answer = Math.Min(answer, count);
            
            return;
        }
        
        if(idx >= intArr.GetLength(0)){
            idx -= intArr.GetLength(0);
            for(int i = 0; i < intArr.GetLength(0); i++)
                intArr[i, idx] *= -1;
            dfs(cur +1, count +1, intArr, ref answer);
            
            for(int i = 0; i < intArr.GetLength(0); i++)
                intArr[i, idx] *= -1;
            dfs(cur +1, count, intArr, ref answer);
        }else{
            for(int i = 0; i < intArr.GetLength(1); i++)
                intArr[idx, i] *= -1;
            dfs(cur +1, count +1, intArr, ref answer);
            
            for(int i = 0; i < intArr.GetLength(1); i++)
                intArr[idx, i] *= -1;
            dfs(cur +1, count, intArr, ref answer);
        }
    }
}
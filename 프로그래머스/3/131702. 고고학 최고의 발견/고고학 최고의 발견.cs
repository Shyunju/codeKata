using System;

public class Solution {
    int[,] map;
    int[] rotationCount;
    int[] dx = {0, 0, 0, 1, -1};
    int[] dy = {0, 1, -1, 0, 0};
    int n,answer = Int32.MaxValue;
    
    public int solution(int[,] clockHands) {
        n = clockHands.GetLength(0);
        map = new int[n,n];
        rotationCount = new int[n];
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                map[i,j] = 4 - clockHands[i,j] == 4 ? 0 : 4 - clockHands[i,j];
            }
        }
        dfs(0);
        return answer;
    }
    private void dfs(int idx){
        if(idx == n){
            int[,] mapClone = (int[,])map.Clone();
            int[] rotationClone = (int[])rotationCount.Clone();
            int total = 0;
            
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    total += rotationClone[j];
                    if(total >= answer) return;
                    
                    for(int d = 0; d < 5; d++){
                        int x = i + dx[d];
                        int y = j + dy[d];
                        
                        if( x < 0 || x >= n || y < 0 || y >= n) continue;
                        
                        mapClone[x,y] = mapClone[x,y] - rotationClone[j] >= 0 ? mapClone[x,y] - rotationClone[j] : mapClone[x,y] - rotationClone[j] +4;
                    }
                }
                for(int j = 0; j < n; j++)
                    rotationClone[j] = mapClone[i,j];
            }
            for(int i =0; i< n; i++)
                if(rotationClone[i] != 0) return;
            
            answer = Math.Min(answer, total);
            return;
        }
        for(int i = 0; i < 4; i++){
            rotationCount[idx] = i;
            dfs(idx +1);
        }
    }
}
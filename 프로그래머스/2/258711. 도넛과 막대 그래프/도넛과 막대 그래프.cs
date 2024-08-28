using System;

public class Solution {
    public int[] solution(int[,] edges) {
        int[] answer = new int[4];
        
        int nodeCnt = 0;
        int edgeCnt = edges.GetLength(0);
        for(int i = 0; i < edgeCnt; i++){
            if(edges[i,0] > nodeCnt) nodeCnt = edges[i,0];
            if(edges[i,1] > nodeCnt) nodeCnt = edges[i,1];
        }
        int[,] lines = new int[nodeCnt + 1,2];
        bool[] exist = new bool[nodeCnt+ 1];
        
        for(int i = 0; i < edgeCnt; i++){
            int start = edges[i, 0];
            int end = edges[i, 1];
            
            exist[start] = true;
            exist[end] = true;
            
            lines[start, 0]++;
            lines[end, 1]++;
        }
        for(int i = 1; i <= nodeCnt; i++){
            if(i == answer[0] || !exist[i]) continue;
            if(lines[i,0] >= 2 && lines[i,1] == 0) answer[0] = i;
            
            if(lines[i,0] == 0) answer[2]++;
            if(lines[i,0] >= 2 && lines[i,1] >= 2) answer[3]++;
        }
        
        answer[1] = lines[answer[0],0] - answer[2] -answer[3];
        return answer;
    }
}
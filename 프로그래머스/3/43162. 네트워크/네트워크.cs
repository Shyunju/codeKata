using System;

public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        bool[] visited = new bool[n];
        
        for(int i = 0; i < n; i++){
            if(!visited[i]){
                answer++;
                DFS(computers, visited, i);
            }
        }
        return answer;
    }
    private void DFS(int[,] computers, bool[] visited, int cur){
        visited[cur] = true;
        for(int i = 0; i < computers.GetLength(0); i++){
            if(computers[cur, i] == 1 && !visited[i]){
                DFS(computers, visited, i);
            }
        }
    }
}
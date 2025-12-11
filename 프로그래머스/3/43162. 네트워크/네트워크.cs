using System;

public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        bool[] visited = new bool[n];
        for(int i = 0; i < n; i++)
        {
            if(!visited[i])
            {
                answer++;
                DFS(computers, visited, i);
            }
        }
        return answer;
    }
    void DFS(int[,] computers, bool[] visited, int start)
    {
        visited[start] = true;
        for(int i = 0; i < computers.GetLength(0); i++)
        {
            if(!visited[i] && computers[start, i] == 1)
                DFS(computers, visited, i);
        }
    }
}
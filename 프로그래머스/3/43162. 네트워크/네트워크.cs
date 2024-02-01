using System;

public class Solution {
    public int solution(int n, int[,] computers) 
    {
        bool[] visited = new bool[n];       

        int answer = 0;

        for(int i = 0; i < n; i++)
        {
            if (visited[i] == false) { 
                answer++;
                DFS(computers, visited, i);
            }
        }
        return answer;
    }

    public static void DFS(int[,] computers, bool[] visited, int start)
    {
        visited[start] = true;
        for(int i = 0; i < computers.GetLength(0); i++)
        {
            if (computers[start, i] == 1 && !visited[i])
                DFS(computers, visited, i);
        }
    }
}
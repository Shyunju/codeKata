using System;

public class Solution {
    int[] dirY = {-1, 1, 0, 0};
    int[] dirX = {0, 0, -1, 1};
    public int solution(int[,] board, int[] aloc, int[] bloc) {
        bool[,] visited = new bool[5, 5];
        return BFS(aloc[0], aloc[1], bloc[0], bloc[1], board, visited);
    }
    private int BFS(int myY, int myX, int otherY, int otherX, int[,] board, bool[,] visited){
        if(visited[myY, myX]) return 0;
        int canWin = 0;
        visited[myY, myX] = true;
        
        for(int i = 0; i < 4; i++){
            int nextY = myY + dirY[i];
            int nextX = myX + dirX[i];
            
            if(nextY < 0 || nextY >= board.GetLength(0) || nextX < 0 || nextX >= board.GetLength(1)) continue;
            if(visited[nextY, nextX] || board[nextY, nextX] == 0) continue;
            
            int nextResult = BFS(otherY, otherX, nextY, nextX, board, visited)+1;
            
            if(canWin % 2 == 0 && nextResult % 2 == 1) canWin = nextResult;
            else if(canWin % 2 == 0 && nextResult % 2 == 0) canWin = Math.Max(canWin, nextResult);
            else if(canWin % 2 == 1 && nextResult % 2 == 1) canWin = Math.Min(canWin, nextResult);
        }
        visited[myY, myX] = false;
        return canWin;
        
    }
}
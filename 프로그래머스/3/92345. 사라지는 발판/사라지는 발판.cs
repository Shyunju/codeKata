using System;

public class Solution {
    int[] dX = {-1, 1, 0, 0};
    int[] dY = {0, 0, -1 , 1};
    bool[,] visited = new bool[5,5];
    
    public int solution(int[,] board, int[] aloc, int[] bloc) {
        
        return GetMoveCount(aloc[0], aloc[1], bloc[0], bloc[1], board);
    }
    
    // 현재 플레이어, 상대 플레이어 넘기며 count 세기
    public int GetMoveCount(int myX, int myY, int otherX, int otherY, int[,] board)
    {
        if (visited[myX, myY]) return 0;
        int canWin = 0;
        visited[myX, myY] = true;
        
        for (int i = 0; i < 4; i++)
        {
            int newX = myX + dX[i];
            int newY = myY + dY[i];
            // 보드 범위 밖
            if (newX < 0 || newY < 0 || newX >= board.GetLength(0) || newY >= board.GetLength(1)) continue;
            // 발판 사라졌거나 없는 경우
            if (visited[newX, newY] || board[newX, newY] == 0) continue;
            
            // 현재 플레이어 기준 상대 플레이어로 턴 넘기기
            int otherMoveCount = GetMoveCount(otherX, otherY, newX, newY, board) + 1; // 상대의 결과가 지는 경우 (0) => 나는 이기는 것 (1), 상개가 이기는 경우 (1) => 나는 지는 것 (0)
            
            // 현재 저장된 값 패배, 상대가 지는 경우 => 이기는 경우로 저장
            if (canWin % 2 == 0 && otherMoveCount % 2 == 1) canWin = otherMoveCount;
            // 현재 저장된 값 패배, 상대가 이기는 경우 => 최대한 늦게 지도록
            else if (canWin % 2 == 0 && otherMoveCount % 2 == 0) canWin = Math.Max(canWin, otherMoveCount);
            // 현재 저장된 값 승리, 상대가 지는 경우 => 최대한 빨리 이기도록
            else if (canWin % 2 == 1 && otherMoveCount % 2 == 1) canWin = Math.Min(canWin, otherMoveCount);
        }
        
        visited[myX, myY] = false;
        
        return canWin;
    }
}
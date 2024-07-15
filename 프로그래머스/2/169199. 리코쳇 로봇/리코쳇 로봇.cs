using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] board) 
    {
        (int y, int x) target = (-1, -1);
        var open = new Queue<(int, int)>();
        var dist = new int[board.Length, board[0].Length]; 

        // 초기 세팅
        for(int y = 0; y < board.Length; ++y)
        {
            for(int x = 0; x < board[0].Length; ++x)
            {
                if(board[y][x] == 'D')
                    dist[y, x] = -1;
                else if(board[y][x] == 'R')
                    open.Enqueue((y, x));
                else if(board[y][x] == 'G')
                    target = (y, x);
            }
        }

        // 탐색
        int[] dy = new int[4]{ -1, 1, 0, 0 };
        int[] dx = new int[4]{ 0, 0, -1, 1 };
        while(open.Count > 0)
        {
            (int y, int x) point = open.Dequeue();

            if(point.y == target.y && point.x == target.x) // 도착
                break;

            int curDist = dist[point.y, point.x];
            for(int i = 0; i < 4; ++i) // 4방향으로
            {
                int y = point.y;
                int x = point.x;

                while(true) // 벽 혹은 가장자리를 만날 때까지 최대로 미끄러진다.
                {
                    int nextY = y + dy[i];
                    int nextX = x + dx[i];

                    if(nextY < 0 || nextY >= board.Length) break;
                    if(nextX < 0 || nextX >= board[0].Length) break;
                    if(board[nextY][nextX] == 'D') break;

                    y = nextY;
                    x = nextX;
                }

                if(y == point.y && x == point.x) // 진행하지 못한경우 취소
                    continue;

                if(dist[y, x] == 0)
                {
                    open.Enqueue((y, x));
                    dist[y, x] = curDist + 1; // visited를 겸함
                }
            }
        }

        return dist[target.y, target.x] > 0 ? dist[target.y, target.x] : -1;
    }
}
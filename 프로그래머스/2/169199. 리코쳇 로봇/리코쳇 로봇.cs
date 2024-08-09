using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] board) {
        (int y, int x) goal = (-1, -1);
        int[,] dist = new int[board.Length, board[0].Length];
        Queue<(int, int)> open = new Queue<(int, int)>();
        
        for(int y = 0; y <board.Length; y++){
            for(int x = 0; x < board[0].Length; x++){
                switch(board[y][x]){
                    case 'D' :
                        dist[y,x] = -1;
                        break;
                    case 'R' :
                        open.Enqueue((y,x));
                        break;
                    case 'G' :
                        goal = (y,x);
                        break;
                }
            }
        }
        
        int[] dy = new int[4]{-1, 1, 0, 0};
        int[] dx = new int[4]{0, 0, -1, 1};
        
        while(open.Count > 0){
            (int y, int x) point = open.Dequeue();
            
            if( point.y == goal.y && point.x == goal.x) break;
            
            int curDist = dist[point.y, point.x];
            for(int i = 0; i < 4; i++){
                int y = point.y;
                int x = point.x;
                
                while(true){
                    int nextY = y + dy[i];
                    int nextX = x + dx[i];
                    
                    if(nextY < 0 || nextY >= board.Length || nextX < 0 || nextX >= board[0].Length) break;
                    if(board[nextY][nextX] == 'D') break;
                    
                    y = nextY;
                    x = nextX;
                }
                if(y == point.y && x == point.x) continue;
                
                if(dist[y,x] == 0){
                    dist[y,x] = curDist + 1;
                    open.Enqueue((y, x));
                }
            }
        }
        return dist[goal.y, goal.x] > 0 ? dist[goal.y, goal.x] : -1;
    }
}
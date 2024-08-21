using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[,] places) {
        int[] answer = new int[5];
        
        for(int i = 0; i < 5; i++){
            bool possible = true;
            for(int y = 0; y < 5; y++){
                for(int x = 0; x < 5; x++){
                    if(places[i,y][x] == 'P') possible = bfs(i, y, x, places);
                    if(!possible) break;
                }
                if(!possible) break;
            }
            if(possible) answer[i] = 1;
        }
        
        return answer;
    }
    private bool bfs(int i , int y, int x, string[,] places){
        int[] dy = new int[4]{-1, 1, 0, 0};
        int[] dx = new int[4]{0, 0, -1, 1};
        
        var q = new Queue<(int, int, int)>();
        q.Enqueue((y, x, 0));
        
        while(q.Count > 0){
            var cur = q.Dequeue();
            
            for(int j = 0; j < 4; j++){
                int posY = cur.Item1 + dy[j];
                int posX = cur.Item2 + dx[j];
                int dir = cur.Item3 + 1;
                
                if(posY < 0 || posY > 4 || posX < 0 || posX > 4) continue;
                if(posY == y && posX == x) continue;
                
                if(places[i, posY][posX] == 'P') return false;
                if(places[i,posY][posX] == 'O' && dir < 2){
                    q.Enqueue((posY,posX,dir));
                }
            }
        }
        return true;
    }
}
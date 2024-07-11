using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] maps) {
        
        var startPiont = FindPoint(maps, 'S');
        int StoL = Move(maps, 'L', startPiont, out var leverPoint);
        if(StoL == -1)
            return -1;
        else{
            int LtoE = Move(maps, 'E', leverPoint, out var exit);
            return LtoE == -1 ? -1 : StoL + LtoE;
        }
        
        
    }
    public (int, int) FindPoint(string[] maps, char c){
        for(int y = 0; y <maps.Length; y++){
            int x = maps[y].IndexOf(c);
            if( x != -1)
                return (y, x);
        }
        return (-1, -1);
    }
    
    public int Move(string[] maps, char target, (int, int) start, out (int, int) end){
        
        var dist = new int[maps.Length, maps[0].Length];
        
        int[] dy = {0, 0, -1, 1};
        int[] dx = {-1, 1, 0, 0};
        
        var q = new Queue<(int, int)>();
        q.Enqueue(start);
        
        while(q.Count > 0){
            (int y, int x) cur = q.Dequeue();
            if(maps[cur.y][cur.x] == target){
                end = cur;
                return dist[cur.y, cur.x];
            }
            for(int i = 0; i < 4; i++){
                int nextY = cur.y + dy[i];
                int nextX = cur.x + dx[i];
                
                if(nextY < 0 || nextY >= maps.Length || nextX < 0 || nextX >= maps[0].Length) continue;
                if(maps[nextY][nextX] == 'X') continue;
                
                if(dist[nextY, nextX] != 0) continue;
                
                dist[nextY, nextX] = dist[cur.y, cur.x] +1;
                q.Enqueue((nextY, nextX));
            }
        }
        end = (-1, -1);
        return -1;
    }
}
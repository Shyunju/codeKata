using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    string[] grid;
    bool[,,] visit;
    int[] dy = new int[]{-1, 1, 0, 0};
    int[] dx = new int[]{0, 0, -1, 1};
    public int[] solution(string[] grid) {
        var answer = new List<int>();
        
        this.grid = grid;
        int y = grid.Length;
        int x = grid[0].Length;
        visit = new bool[y,x,4];
        
        for(int i = 0; i < y; i++){
            for( int j = 0; j < x; j++){
                for(int d = 0; d < 4; d++){
                    if( !visit[i,j,d]) answer.Add(LightCycle(i, j, d));
                }
            }
        }
        return answer.OrderBy( i => i).ToArray();
    }
    private int LightCycle(int y, int x, int d){
        int cnt = 0;
        
        while(!visit[y,x,d]){
            ++cnt;
            visit[y,x,d] = true;
            
            if(grid[y][x] == 'L'){
                if( d <= 1) d +=2;
                else if( d == 2) d = 1;
                else if( d == 3) d = 0;
            }
            else if(grid[y][x] == 'R'){
                if( d >= 2) d -= 2;
                else if(d == 0) d = 3;
                else if(d == 1) d = 2;
            }
            
            y = (y + dy[d] + grid.Length) % grid.Length;
            x = (x + dx[d] + grid[0].Length) % grid[0].Length;
            
        }
        return cnt;
    }
}
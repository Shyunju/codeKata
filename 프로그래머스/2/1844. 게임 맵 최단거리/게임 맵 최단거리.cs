using System;
using System.Collections.Generic;

class Solution {
    int n, m =0;
    
    int[] dx = {-1, 1, 0, 0};
    int[] dy = {0, 0, -1, 1};
    
    Queue<(int, int)> q = new Queue<(int, int)>();
    public int solution(int[,] maps) {
        n = maps.GetLength(0);
        m = maps.GetLength(1);
        
        Bfs(0,0, maps);
        
        if(maps[n-1, m-1] == 1) return -1;
        else return (maps[n-1, m-1]);
    }
    
    public void Bfs(int i, int j, int[,] arr)
    {
        q.Enqueue((i,j));
        
        while(q.Count != 0)
        {
            (int a, int b) = q.Dequeue();
            
            for(int k = 0; k < 4; k++)
            {
                int nx = a + dx[k];
                int ny = b + dy[k];
                
                if( nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                if(arr[nx, ny] == 0) continue;
                if(arr[nx, ny] == 1)
                {
                    arr[nx, ny] = arr[a, b] + 1;
                    q.Enqueue((nx, ny));
                }
            }
        }
    }
}
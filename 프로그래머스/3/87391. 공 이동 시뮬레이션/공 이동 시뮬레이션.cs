using System;

public class Solution {
    public long solution(int n, int m, int x, int y, int[,] queries) {
        long x1 = x, y1 = y, x2 = x, y2 =y;
        
        for(int i = queries.GetLength(0) -1 ; i >= 0; i--){
            int dir = queries[i,0];
            int dx = queries[i,1];
            
            switch(dir){
                case 2:
                    if(x1 != 0) x1 += dx;
                    x2 += dx;
                    break;
                case 3:
                    if(x2 != n-1) x2 -= dx;
                    x1 -= dx;
                    break;
                case 0:
                    if(y1 != 0) y1 += dx;
                    y2 += dx;
                    break;
                case 1:
                    if(y2 != m-1) y2 -= dx;
                    y1 -= dx;
                    break;
            }
            if(x1 >= n || y1 >= m || x2 <0 || y2 < 0)   return 0;
            x1 = Math.Max(0, x1);
            y1 = Math.Max(0, y1);
            x2 = Math.Min(x2, n-1);
            y2 = Math.Min(y2, m-1);
        }
        return (x2-x1+1)*(y2-y1+1);
    }
}
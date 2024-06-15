using System;

public class Solution {
    public int solution(int[,] sizes) {
        int[,] sort = new int[sizes.GetLength(0),sizes.GetLength(1)];
        
        int width = 0;
        int height = 0;
        
        for(int i= 0 ; i < sizes.GetLength(0); i++){
            sort[i, 0] = Math.Max(sizes[i,0], sizes[i,1]);
            sort[i, 1] = Math.Min(sizes[i,0], sizes[i,1]);
            
            width = Math.Max(width, sort[i,0]);
            height = Math.Max(height, sort[i,1]);
        }
        return width * height;
    }
}
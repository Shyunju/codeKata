using System;

public class Solution {
    public int solution(int[,] sizes) {
        int max1 = 0;
        int max2 = 0;
        for( int i = 0; i < sizes.GetLength(0); i++){
            int tmp = 0;
            if( sizes[i,0] < sizes[i,1]){
                tmp = sizes[i,0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = tmp;
            }
            
            
        }
        for( int i = 0; i < sizes.GetLength(0); i++){
            if( max1 < sizes[i,0])
                max1 = sizes[i,0];
            if(max2 < sizes[i,1])
                max2 = sizes[i,1];
        }
        return max1 * max2;
    }
}
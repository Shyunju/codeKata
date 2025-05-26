using System;
using System.Linq;
public class Solution {
    public int solution(int[,] sizes) {
        int[] width = new int[sizes.GetLength(0)];
        int[] height = new int[sizes.GetLength(0)];
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if(sizes[i,0] >= sizes[i,1])
            {
                width[i] = sizes[i,0];
                height[i] = sizes[i,1];
            }else{
                width[i] = sizes[i,1];
                height[i] = sizes[i,0];
            }
        }
        return width.Max() * height.Max();
    }
}
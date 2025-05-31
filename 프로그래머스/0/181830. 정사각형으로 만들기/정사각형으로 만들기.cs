using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int y = arr.GetLength(0);
        int x = arr.GetLength(1);
        int max = y > x ? y : x;
        int[,] answer = new int[max, max];
        for(int i = 0; i < y; i++)
        {
            for(int j = 0; j < x; j++)
            {
                answer[i,j] = arr[i,j];
            }
        }
        return answer;
    }
}
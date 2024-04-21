using System;
using System.Linq;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int[] x = new int[4];
        int[] y = new int[4];
        
        for(int i = 0; i < 4; i++)
        {
            x[i] = dots[i,0];
            y[i] = dots[i,1];
        }
        answer = (x.Max() - x.Min()) * (y.Max() - y.Min());
        return answer;
    }
}
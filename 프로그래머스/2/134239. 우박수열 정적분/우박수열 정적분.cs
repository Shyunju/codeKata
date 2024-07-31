using System;
using System.Collections.Generic;
public class Solution {
    public double[] solution(int k, int[,] ranges) {
        double[] answer = new double[ranges.GetLength(0)];
        
        var dots = new List<(int x, int y)>();
        dots.Add((0,k));
        
        int i = 1;
        while( k > 1){
            if(k % 2 == 0)
                k /= 2;
            else
                k = k * 3 + 1;
            
            dots.Add((i, k));
            i++;
        }
        for(int j = 0; j < ranges.GetLength(0); j++){
            int left = ranges[j,0];
            int right = dots.Count + ranges[j,1] -1;
            
            if(left > right){
                answer[j] = -1;
                continue;
            }
            double sum = 0d;
            for(int l = left; l < right; l++){
                sum += Math.Min(dots[l].Item2, dots[l+1].Item2);
                sum += Math.Abs(dots[l].Item2 - dots[l+1].Item2) * 0.5d;
            }
            answer[j] = sum;
        }
        return answer;
    }
}
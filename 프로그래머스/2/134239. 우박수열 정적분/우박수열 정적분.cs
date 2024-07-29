using System;
using System.Collections.Generic;
public class Solution {
    public double[] solution(int k, int[,] ranges) 
    {
        var dots = new List<(int x, int y)>();
        dots.Add((0, k));

        int i = 1;
        while(k > 1)
        {
            if(k % 2 == 0)
                k = k / 2;
            else
                k = k * 3 + 1;

            dots.Add((i, k));
            ++i;
        }

        var answer = new double[ranges.GetLength(0)];
        for(int j = 0; j < ranges.GetLength(0); ++j)
        {
            int left = ranges[j, 0];
            int right = dots.Count + ranges[j, 1] - 1;
            if(left > right)
            {
                answer[j] = -1;
                continue;
            }

            double sum = 0d;
            for(int x = left; x < right; ++x)
            {
                sum += Math.Min(dots[x].Item2, dots[x + 1].Item2); // 사각형
                sum += Math.Abs(dots[x].Item2 - dots[x + 1].Item2) * 0.5d; // 삼각형
            }
            answer[j] = sum;
        }

        return answer;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[score.GetLength(0)];
        List<double> avg = new List<double>();
        List<double> lank = new List<double>();
        for(int i = 0; i <score.GetLength(0); i++)
        {
            double num = (score[i,0] +score[i,1]) / (double)2;
            avg.Add(num);
            lank.Add(num);
        }
        
        lank.Distinct();
        lank.Sort();
        lank.Reverse();
        
        for(int i = 0; i < avg.Count; i++)
        {
            answer[i] = lank.IndexOf(avg[i])+1;
        }
        return answer;
    }
}
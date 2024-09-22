using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] scores) {
        int answer = 1;
        
        List<(int, int)> scoreList = new List<(int, int)>();
        
        for (int i = 1; i < scores.GetLength(0); i++)
        {
            scoreList.Add((scores[i, 0], scores[i, 1]));
        }
        
        scoreList = scoreList.OrderByDescending(x => x.Item1).ThenBy(x => x.Item2).ToList();

        int currentScore = scores[0, 0] + scores[0, 1];
        int maxEmployeeEvalScore = 0;
        foreach (var score in scoreList)
        {
            if (scores[0, 0] < score.Item1 && scores[0, 1] < score.Item2) return -1;
            if (maxEmployeeEvalScore <= score.Item2) 
            {
                if (currentScore < score.Item1 + score.Item2) answer += 1;
                maxEmployeeEvalScore = score.Item2;
            }
            
        }
        
        return answer;
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] scores) {
        int answer = 1;
        int myScore = scores[0,0] + scores[0,1];
        var scoreList = new List<(int, int)>();
        
        for(int i = 0; i < scores.GetLength(0); i++){
            scoreList.Add((scores[i,0], scores[i,1]));
        }
        
        scoreList.Sort(delegate ((int, int)a, (int, int)b){
            if(a.Item1 == b.Item1)  return a.Item2.CompareTo(b.Item2);
            return b.Item1.CompareTo(a.Item1);
        });
        
        int max2Score = 0;
        foreach((int, int)i in scoreList){
            if(scores[0, 0] < i.Item1 && scores[0,1] < i.Item2)  return -1;
            if(i.Item2 >= max2Score){
                if(myScore < i.Item1 + i.Item2) answer++;
                max2Score = i.Item2;
            }
        }
        return answer;
    }
}
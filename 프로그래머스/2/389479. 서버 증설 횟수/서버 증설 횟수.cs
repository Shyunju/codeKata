using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] players, int m, int k) {
        int answer = 0;
        List<int> timeOver = new List<int>();
        for(int i = 0; i < 24; i++)
        {
            timeOver = timeOver.Where(w => w != i).ToList();
            if(players[i] / m < timeOver.Count)  //증설필요 없음
                continue;
            int need = players[i] /m - timeOver.Count;
            answer += need;
            for(int j = 0; j < need; j++)
            {
                timeOver.Add(i+k);
            }            
        }
        return answer;
    }
}
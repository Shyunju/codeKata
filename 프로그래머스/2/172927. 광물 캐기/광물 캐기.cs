using System;

public class Solution {
    public int solution(int[] picks, string[] minerals) 
    {
        int[,] pickCost = new int[3, 3]{ {1, 1, 1}, {5, 1, 1}, {25, 5, 1} };
        int[] mineralIndexs = new int[minerals.Length];
        for(int i = 0; i < minerals.Length; ++i)
        {
            switch(minerals[i])
            {
                case "diamond": mineralIndexs[i] = 0; break;
                case "iron": mineralIndexs[i] = 1; break;
                case "stone": mineralIndexs[i] = 2; break;
                default: break;
            }
        }

        int answer = int.MaxValue;
        DFS(picks, mineralIndexs, pickCost, 0, 0, ref answer);
        return answer;
    }

    private void DFS(int[] picks, int[] mineralIndexs, int[,] pickCost, int n, int fatigue, ref int answer)
    {
        const int MAX_PICK = 5;

        if(n >= mineralIndexs.Length) // 광물을 다 캐버림
        {
            if(fatigue < answer)
                answer = fatigue;
        }

        bool isAnyPick = false;
        for(int i = 0; i < 3; ++i)
        {
            if(picks[i] == 0) continue;
            isAnyPick = true;

            int curFatigue = 0;
            for(int k = 0; k < MAX_PICK; ++k)
            {
                if(n + k >= mineralIndexs.Length) break;
                int mineIndex = mineralIndexs[n + k];
                curFatigue += pickCost[i, mineIndex];
            }

            --picks[i];
            DFS(picks, mineralIndexs, pickCost, n + MAX_PICK, fatigue + curFatigue, ref answer);
            ++picks[i];
        }

        if(!isAnyPick) // 곡괭이를 다 써버림
        {
            if(fatigue < answer)
                answer = fatigue;
        }
    }
}
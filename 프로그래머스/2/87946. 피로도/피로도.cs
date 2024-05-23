using System;

public class Solution {

    public bool[] visit;
    public int answer=0;
    
    public int solution(int k, int[,] dungeons) {
        visit = new bool[dungeons.Length];
        func(k,dungeons,visit,0);
        
        return answer;
    }

    public int func(int k, int[,] dungeons,bool[]visit,int cnt)
    {
        for(int i=0; i<dungeons.GetLength(0); i++)
        {
            if(k>=dungeons[i,0] && !visit[i]) 
            {
                visit[i] = true;
                func(k - dungeons[i,1],dungeons,visit,cnt+1);
                visit[i] = false; 
            }
        }
        answer= Math.Max(cnt, answer);
        return answer;
    }
}
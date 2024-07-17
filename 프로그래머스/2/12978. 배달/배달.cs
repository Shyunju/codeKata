using System;
using System.Linq;
class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int[,] map = new int[N, N];
        for(int i = 0; i < N; i++)
        {
            for(int k = 0; k < N; k++)
                map[i, k] = int.MaxValue;
        }
        for(int i = 0; i < road.GetLength(0); i++)
        {
            int a = road[i, 0] - 1;
            int b = road[i, 1] - 1;
            int dist = road[i, 2];

            if(dist < map[a, b])
                map[a, b] = map[b, a] = dist;
        }

        var times = new int[N];
        var visit = new bool[N];
        for(int i = 0; i < N; i++)
            times[i] = map[0, i];

        times[0] = 0; 
        visit[0] = true; 

        for(int repeat = 0; repeat < N - 1; repeat++)
        {
            int now = -1;
            int min = int.MaxValue;
            for(int j = 0; j < N; j++)
            {
                if(visit[j]) continue;
                if(times[j] == int.MaxValue) continue;
                if(times[j] >= min) continue;

                min = times[j];
                now = j;
            }

            visit[now] = true;

            for(int k = 0; k < N; k++)
            {
                if(visit[k]) continue;
                if(map[now, k] == int.MaxValue) continue;
                if(times[k] > times[now] + map[now, k]) 
                    times[k] = times[now] + map[now, k];
            }
        }

        return times.Count(c => c <= K);
    }
}
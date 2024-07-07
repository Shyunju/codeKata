using System;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        int[] result = new int[N+1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 999999;
        }
        result[1] = 0;

        for (int k = 0; k < N; k++)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < road.GetLength(0); j++)
                {
                    if(road[j,0] == i)
                    {
                        if(result[road[j,1]]>result[road[j,0]]+road[j,2])
                        {
                            result[road[j,1]] =result[road[j, 0]] + road[j, 2];
                        }
                        else   result[road[j, 1]] = result[road[j, 1]];
                    }
                    else if(road[j,1] == i)
                    {
                        if(result[road[j,0]]>result[road[j,1]]+road[j,2])
                        {
                            result[road[j,0]] =result[road[j, 1]] + road[j, 2];
                        }
                        else result[road[j,0]] = result[road[j, 0]];
                    }
                }
            }
        }
        for (int i = 1; i < result.Length; i++)
        {
            if (result[i] <= K)
            {
                answer++;
            }
        }
        return answer;
    }
}

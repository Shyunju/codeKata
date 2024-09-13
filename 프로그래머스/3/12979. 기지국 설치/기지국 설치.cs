using System;

class Solution
{
    public int solution(int n, int[] stations, int w)
    {
        int answer = 0;
        int station = 0;
        int now = 1;
        while (now <= n)
        {
            if (station < stations.Length && now >= stations[station] - w)
            {
                now = stations[station] + w + 1;
                station++;
            }
            else
            {
                now += w + w + 1;
                answer++;
            }
        }
        return answer;
    }
}
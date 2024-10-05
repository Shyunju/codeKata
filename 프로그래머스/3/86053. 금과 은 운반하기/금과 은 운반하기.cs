using System;

    public class Solution
    {
        public long solution(int a, int b, int[] g, int[] s, int[] w, int[] t)
        {
            // 이분 탐색을 위한 최소 시간과 최대 시간 범위
            long minTime = 1;
            long maxTime = 1;

            // 모든 도시의 자원을 옮기기 위해 걸리는 최대 시간 세팅
            for (int i = 0; i < g.Length; i++)
            {
                long weight = g[i] + s[i]; // 총 무게
                long count = weight / w[i]; // 운반 횟수
                if (0 < weight % w[i])
                    count++;
                    
                long time = 2 * t[i] * count; // 걸리는 시간
                maxTime = Math.Max(maxTime, time);
            }

            // 이분탐색
            while (minTime <= maxTime)
            {
                long midTime = (minTime + maxTime) / 2;
                
                // 모든 자원을 얻을 수 있는 시간인가?
                if (Function(a, b, g, s, w, t, midTime))
                    maxTime = midTime - 1;
                else
                    minTime = midTime + 1;
            }

            return maxTime;
        }

        // 해당 시간 안에 새 도시를 짓기 위한 자원을 모두 운반할 수 있는지 여부
        public bool Function(int a, int b, int[] g, int[] s, int[] w, int[] t, long time)
        {
            // 시간 안에 이동시킬 수 있는 최대 광물 무게
            long total = 0; // 금 + 은
            long totalG = 0; // 금
            long totalS = 0; // 은

            for (int i = 0; i < g.Length; i++)
            {
                // 시간 안에 옮길 수 있는 최대 무게
                long maxWeight = (time / (2 * t[i])) * w[i];
                if (t[i] < time % (2 * t[i]))
                    maxWeight += w[i];

                // 누적 최대 광물 무게
                total += Math.Min(g[i] + s[i], maxWeight);
                totalG += Math.Min(g[i], maxWeight);
                totalS += Math.Min(s[i], maxWeight);
            }

            return (a + b <= total) && a <= totalG && b <= totalS;
        }
    }
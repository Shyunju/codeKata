using System;

    public class Solution
    {
        public long solution(int a, int b, int[] g, int[] s, int[] w, int[] t)
        {
            long minTime = 1;
            long maxTime = 1;

            for (int i = 0; i < g.Length; i++)
            {
                long weight = g[i] + s[i];
                long count = weight / w[i]; 
                if (0 < weight % w[i])
                    count++;
                    
                long time = 2 * t[i] * count;  
                maxTime = Math.Max(maxTime, time);
            }

            while (minTime <= maxTime)
            {
                long midTime = (minTime + maxTime) / 2;
                
                if (Enough(a, b, g, s, w, t, midTime))
                    maxTime = midTime - 1;
                else
                    minTime = midTime + 1;
            }

            return maxTime;
        }

        public bool Enough(int a, int b, int[] g, int[] s, int[] w, int[] t, long time)
        {
            long total = 0; // 금 + 은
            long totalG = 0; // 금
            long totalS = 0; // 은

            for (int i = 0; i < g.Length; i++)
            {
                long maxWeight = (time / (2 * t[i])) * w[i];
                if (t[i] < time % (2 * t[i]))
                    maxWeight += w[i];

                total += Math.Min(g[i] + s[i], maxWeight);
                totalG += Math.Min(g[i], maxWeight);
                totalS += Math.Min(s[i], maxWeight);
            }

            return (a + b <= total) && a <= totalG && b <= totalS;
        }
    }
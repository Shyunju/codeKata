using System;
    using System.Text;

    public class Solution
    {
        public int solution(int n, int k)
        {
            int answer = 0;
            long num = 0;
            StringBuilder sb = new StringBuilder();

            while (n != 0)
            {
                sb.Insert(0, (n % k).ToString());
                n /= k;
            }

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] != '0')
                {
                    num *= 10;
                    num += (long)sb[i] - '0';
                }
                else
                {
                    if (Function(num))
                        answer++;
                    num = 0;
                }
            }

            if (Function(num))
                answer++;
                
            return answer;
        }

        public bool Function(long num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;

            return true;
        }
    }
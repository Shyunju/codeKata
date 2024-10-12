using System;

    public class Solution
    {
        public int[] solution(int e, int[] starts)
        {
            int[] answer = new int[starts.Length];
            var countArray = new int[e + 1]; // 해당 인덱스의 숫자가 등장한 횟수를 담을 배열
            var dp = new int[e + 1]; // index ~ e범위의 가장 많이 등장한 최소 값

            // countArray 세팅 (억억단 등장 횟수)
            for (int i = 1; i <= e; i++)
            {
                for (int j = 1; j <= e; j++)
                {
                    if (i * j > e)
                        break;

                    countArray[i * j]++;
                }
            }

            // dp 세팅 (i ~ e 범위)
            int maxCount = -1;
            int index = -1;
            // 변하지 않는 기준이 e이므로 역순으로 진행
            for (int i = dp.Length - 1; i >= 0; i--)
            {
                if (maxCount <= countArray[i])
                {
                    maxCount = countArray[i];
                    index = i;
                }

                dp[i] = index;
            }

            // 퀴즈 답 목록 세팅
            for (int i = 0; i < starts.Length; i++)
                answer[i] = dp[starts[i]];

            return answer;
        }
    }
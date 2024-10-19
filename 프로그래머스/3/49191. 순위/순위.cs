using System;

    public class Solution
    {
        public int solution(int n, int[,] results)
        {
            int answer = 0;

            // [이긴 선수, 진 선수] 의 대한 정보가 있으면 true
            var boolArrays = new bool[n + 1, n + 1];

            // 주어진 기본 정보 세팅
            for (int i = 0; i < results.GetLength(0); i++)
                boolArrays[results[i, 0], results[i, 1]] = true;

            // 이어지는 정보 세팅
            for (int i = 1; i <= n; i++) // 나
            {
                for (int win = 1; win <= n; win++) // 나를 이긴 선수
                {
                    for (int lose = 1; lose <= n; lose++) // 나에게 진 선수
                    {
                        // 나를 이긴 선수와 내가 이긴 선수에 대한 정보가 있다면 두 선수의 승패정보 갱신
                        if (boolArrays[win, i] && boolArrays[i, lose])
                        {
                            boolArrays[win, lose] = true;
                        }
                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = 1; j <= n; j++)
                {
                    // i번째 선수와 j번째 선수 사이의 승패 유무를 알 수 있다면
                    if (boolArrays[i, j] || boolArrays[j, i])
                        count++;
                }

                // 모든 선수와의 승패유무가 존재한다면
                if (count + 1 == n)
                    answer++;
            }

            return answer;
        }
    }
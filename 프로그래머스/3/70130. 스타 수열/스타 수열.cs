using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int solution(int[] a)
        {
            int answer = 0;
            var dict = new Dictionary<int, int>(); // <정수 값, 정수 개수>

            // 배열 a안에 존재하는 모든 정수의 개수를 파악
            foreach (int num in a)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict.Add(num, 1);
            }
            
            // 존재하는 모든 key를 교집합으로 두는 스타 수열 구하기 
            foreach (int key in dict.Keys)
            {
                int count = 0; // 스타수열 안에 길이가 2인 부분수열의 개수

                // 스타 수열의 길이를 파악할 필요가 없는 경우
                if (answer > dict[key])
                    continue;

                // key를 교집합으로 갖는 부분 수열의 개수 구하기
                for (int i = 0; i < a.Length - 1; i++)
                {
                    // 부분 수열이 될 수 없는 경우
                    if (a[i] != key && a[i + 1] != key)
                        continue;
                    if (a[i] == a[i + 1])
                        continue;

                    // 부분 수열 발견
                    count++;
                    i++;
                }

                // 최대 값이라면 갱신
                if (answer < count)
                    answer = count;
            }

            // 스타 수열의 길이 = 부분 수열의 개수 * 2
            return answer * 2;
        }
    }
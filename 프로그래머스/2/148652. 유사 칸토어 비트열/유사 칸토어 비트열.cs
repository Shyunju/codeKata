 using System;

    public class Solution
    {
        public int solution(int n, long l, long r)
        {
            int answer = 0;
            
            // 조건의 폐구간의 모든 부분을 순회
            for (l = l - 1; l < r; l++)
                if (Function(l))
                    answer++;

            return answer;
        }

        // 유사 칸토어 비트열이 1이면 true를 반환하는 메서드
        public bool Function(long num)
        {
            if (num % 5 == 2) // "11011" -> "0"
                return false;
            else if (num < 5) // "11011" -> "1"
                return true;
            
            // 현재 유사 칸토어 비트열의 레벨에선 0이라고 확신할 수 없을 경우
            return Function(num / 5);
        }
    }
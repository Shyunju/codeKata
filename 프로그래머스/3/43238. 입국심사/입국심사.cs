using System;
 
class Solution
{
    public long solution(int n, int[] times)
    {
        // 심사관이 심사하는 시간을 오름차순으로 정렬
        Array.Sort(times);
 
        // 최대 심사 시간 = 가장 심사시간이 느린 심사관의 시간 X 사람 수
        long maxTime = (long)n * times[times.Length - 1];
 
        // 최소 심사 시간 초기화
        long minTime = 1;
 
        // 최종 반환할 최소 시간 초기화
        long answer = maxTime;
 
        // 이진 탐색 시작
        // 최소 시간이 최대시간과 같아질 때까지..
        while (minTime <= maxTime)
        {
            // 시간의 중간값 계산
            long midTime = (minTime + maxTime) / 2;
 
            // 처리된 사람 수
            long totalPeople = 0;
 
            foreach (int time in times)
            {
                //현재 시간이 지날 때까지 심사관 한명당 처리한 사람의 수
                long people = midTime / time;
 
                totalPeople += people;
            }
 
            // 처리된 사람수가 목표보다 적다면 덜 처리한것..
            if (totalPeople < n)
            {
                // 중간값을 재설정한다.. + 1분
                minTime = midTime + 1;
            }
            else
            {
                // 있는 사람들을 다 처리했다!
                // 사람들을 다 처리할 수 있는 시간중 최소값을 구해야 한다.
 
                // 현재 중간값이 더 작은 경우 answer 값을 갱신
                answer = Math.Min(answer, midTime);
 
                // 범위를 줄여서 중간값을 다시 체크
                maxTime = midTime - 1;
            }
        }
 
        // 최소 시간 반환
        return answer;
    }
}
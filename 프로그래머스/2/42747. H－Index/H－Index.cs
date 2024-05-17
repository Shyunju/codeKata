using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        
        //H-지수 구하는 방법
        //등재한 전체 논문 중 많이 인용된 순으로 정렬하고
        //논문 수와 같아 지거나 작아지기 시작하면 H-지수
        
        //즉, 배열 citations를 정렬하고 리버스하여 큰 수로부터 내려오게 한 뒤
        //해당 i+1번째가 배열의 수보다 작을 때 까지 개수를 더해 반환
        Array.Sort(citations);
        Array.Reverse(citations);
        
        for(int i = 0; i<citations.Length; i++)
        {
            if((i+1) <= citations[i] ) answer++;
        }
        return answer;
    }
}
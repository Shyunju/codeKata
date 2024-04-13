using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides);
        //b가 가장 긴 경우 a + c가 b보다 크면서 c는 b보다 작거나 같다
        for(int i = 1; i <= sides[1]; i++)
        {
            if(sides[0] + i > sides[1])
                answer++;
        }
        //c가 가장 긴 경우 a + b는 c보다 크면서 c는 b보다 크다
        for(int i = sides[1] + 1; i < sides[0] + sides[1]; i++)
        {
            answer++;
        }
        return answer;
    }
}
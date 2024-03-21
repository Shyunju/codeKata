using System;

public class Solution {
    public int solution(int[] sides) {
        Array.Sort(sides);
        int answer = sides[2] < sides[0] + sides[1] ? 1 : 2;
        return answer;
    }
}
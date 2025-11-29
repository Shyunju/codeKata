using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int count = 2;
        while(count <= n)
        {
            answer += count;
            count += 2;
        }
        return answer;
    }
}
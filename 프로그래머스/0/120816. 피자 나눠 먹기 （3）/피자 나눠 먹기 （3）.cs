using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 1;
        int total = slice;
        while(total / n < 1){
            ++answer;
            total += slice;
        }
        return answer;
    }
}
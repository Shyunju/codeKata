using System;

public class Solution {
    public int solution(int n) {
        double answer = Math.Ceiling(n / (double)7);
        return (int)answer;
    }
}
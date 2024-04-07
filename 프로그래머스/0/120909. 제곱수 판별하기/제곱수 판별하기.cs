using System;

public class Solution {
    public int solution(int n) {
        double answer = Math.Sqrt((double)n);
        
        if((int)answer == answer) return 1;
        else return 2;
    }
}
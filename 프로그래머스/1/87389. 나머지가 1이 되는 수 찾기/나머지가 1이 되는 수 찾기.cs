using System;

public class Solution {
    public int solution(int n) {
        int answer = 2;
        while(true){
            if(n % answer != 1){
                answer++;
                continue;
            }
            break;
        }
        return answer;
    }
}
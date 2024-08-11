using System;

public class Solution {
    public int solution(int n, long l, long r) {
        int answer = 0;
        
        for(l = l -1; l < r; l++){
            if(Cantor(l)) answer++;
        }
        return answer;
    }
    private bool Cantor(long num){
        if( num % 5 == 2) return false;
        else if(num < 5) return true;
        
        return Cantor(num / 5);
    }
}
using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int count = 0;
        
        for(int i = left; i <= right; i++){
            count = 0;
            for(int j= 1; j*j <= i; j++){
                if(j*j == i) count++;
                else if(i % j == 0) count += 2;
            }
            if(count % 2 == 0){
                answer += i;
            }else{
                answer -= i;
            }
        }
        return answer;
    }
}
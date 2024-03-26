using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] fac = new int[11];
        for(int i = 1; i <= 10; i++){
            if(i == 1)
                fac[i] = 1;
            else
                fac[i] = fac[i-1] * i;
            
            if(fac[i] > n)
            {
                answer = i-1;
                break;
            }else if(fac[i] == n){
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}
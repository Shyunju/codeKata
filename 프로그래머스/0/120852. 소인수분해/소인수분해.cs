using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        
        for(int i = 2; i <= n; i++){
            while(n % i == 0){
                answer.Add(i);
                n /= i;
            }
        }
        return answer.Distinct().ToArray();
    }
}
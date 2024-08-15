using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        int answer = 0;
        var q1 = new Queue<long>(queue1.Select(s => (long)s));
        var q2 = new Queue<long>(queue2.Select(s => (long)s));
                       
        long maxCnt = queue1.Length * 3;
        long sum1 = q1.Sum();
        long sum2 = q2.Sum();
        
        if(sum1 == sum2) return 0;
        
        long sum = sum1 + sum2;
        if(sum % 2 == 1) return -1;
        
        long target = sum / (long)2;
        
        while(sum1 != target){
            if(answer >= maxCnt) return -1;
            
            if(sum1 < target){
                long num = q2.Dequeue();
                sum1 += num;
                q1.Enqueue(num);
            }else{
                long num = q1.Dequeue();
                sum1 -= num;
                q2.Enqueue(num);
            }
            ++answer;
        }
        return answer;
    }
}
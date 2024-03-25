using System;

public class Solution {
    public int solution(int[] array, int n) {
        int min = 100;
        int answer = 0;
        
        foreach(int i in array)
        {
            int a = Math.Abs(n - i);
            if( a < min){
                min = a;
                answer = i;
            }else if(a == min){
                answer = i < answer ? i : answer;
            }
            
        }
        return answer;
    }
}
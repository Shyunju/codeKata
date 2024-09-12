using System;

public class Solution {
    public int solution(int[] a) {
        
        int answer = 0;
        int n = a.Length;
        
        if(n == 1) return 1;
        int[] leftMinDp = new int[n];
        int[] rightMinDp = new int[n];
        
        leftMinDp[0] = 1000000000;
        rightMinDp[n-1] = 1000000000;
        int leftMin = 1000000000;
        int rightMin = 1000000000;
        
        for(int i = 0; i < n-1; i++){
            leftMin = Math.Min(leftMin, a[i]);
            rightMin = Math.Min(rightMin, a[n-1-i]);
            
            leftMinDp[i+1] = leftMin;
            rightMinDp[n-2-i] = rightMin;
        }
        for(int i = 0; i < n; i++){
            if(leftMinDp[i] > a[i] || rightMinDp[i] > a[i]) answer++;
        }
        
        return answer;
    }
}
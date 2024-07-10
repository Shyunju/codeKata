using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        return DFS(numbers, target, 0, 0);
    }
    public int DFS(int[] numbers, int target, int idx, int num){
        if(idx == numbers.Length){
            if(num == target)
                return 1;
            return 0;
        }
        
        return DFS(numbers, target, idx+1, num + numbers[idx])+ DFS(numbers, target, idx+1, num - numbers[idx]);
    }
}
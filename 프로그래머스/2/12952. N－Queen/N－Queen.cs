using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] arr = new int[n];
        BackTracking(arr, n, 0, ref answer);
        return answer;
    }
    private void BackTracking(int[] arr, int n, int depth, ref int answer){
        if(depth == n){
            answer++;
            return;
        }
        for(int i = 0; i < n; i++){
            arr[depth] = i;
            if(IsValid(arr, depth)) BackTracking(arr, n, depth+1, ref answer);
        }
    }
    private bool IsValid(int[] arr, int depth){
        for(int x = 0; x < depth; x++){
            if(arr[x] == arr[depth]) return false;
            if(Math.Abs(arr[x] - arr[depth]) == Math.Abs(depth - x )) return false;
        }
        return true;
    }
}
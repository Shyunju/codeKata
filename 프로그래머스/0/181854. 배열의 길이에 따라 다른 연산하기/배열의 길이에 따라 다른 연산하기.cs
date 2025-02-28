using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int m = arr.Length % 2 == 0 ? 1 : 0;
        for(int i = 0; i < arr.Length; i++){
            if(i % 2 == m)
                arr[i] += n;
        }
        return arr;
    }
}
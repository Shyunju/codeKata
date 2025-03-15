using System;

public class Solution {
    public int[] solution(int[] arr) {
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] >= 50 && arr[i] % 2 == 0){
                arr[i] = arr[i] /2;
            }else if(arr[i] < 50 && arr[i] % 2 == 1){
                arr[i] = arr[i] * 2;
            }
        }
        return arr;
    }
}
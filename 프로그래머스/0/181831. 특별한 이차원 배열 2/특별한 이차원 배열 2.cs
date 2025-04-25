using System;

public class Solution {
    public int solution(int[,] arr) {
        for(int i = 0; i < arr.GetLength(0); i++){
            for(int j = 0; j < arr.GetLength(1); j++){
                if(arr[i,j] != arr[j,i])
                    return 0;
            }
        }
        return 1;
    }
}
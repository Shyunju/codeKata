using System;

public class Solution {
    public int solution(int[] arr, int idx) {
        for(int i = idx; i< arr.Length; i++)
        {
            if(arr[i] == 1)
                return i;
        }
        return -1;
    }
}
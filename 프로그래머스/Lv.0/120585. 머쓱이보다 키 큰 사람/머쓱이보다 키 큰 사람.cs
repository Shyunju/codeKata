using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        Array.Sort(array);
        for(int i = 0; i <array.Length; i++){
            if(height < array[i]){
                answer = array.Length - i;
                break;
            }
        }
        return answer;
    }
}
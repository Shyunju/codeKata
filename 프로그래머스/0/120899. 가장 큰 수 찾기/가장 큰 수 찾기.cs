using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int max = 0;
        foreach(int i in array){
            if(i > max)
                max = i;
        }
        answer[0] = max;
        answer[1] = Array.IndexOf(array, max);
        return answer;
    }
}
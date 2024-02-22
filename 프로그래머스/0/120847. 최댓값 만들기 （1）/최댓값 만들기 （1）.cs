using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for(int i = 0; i< numbers.Length -1; i++)
        {
            for(int j = i +1; j< numbers.Length; j++){
                if(numbers[i] * numbers[j] > answer)
                    answer = numbers[i] * numbers[j];
            }
        }
        return answer;
    }
}
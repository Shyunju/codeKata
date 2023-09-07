using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> result = new List<int>();
        int sum = 0;
        for(int i = 0; i < numbers.Length-1; i++){
            for(int j = i + 1; j < numbers.Length; j++){
                sum = numbers[i] + numbers[j];
                if(!result.Contains(sum)){
                    result.Add(sum);
                }
            }
        }
        result.Sort();
        int[] answer = result.ToArray();
        return answer;
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        List<int> answer = new List<int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            answer.Add(numbers[i] * 2);
        }
        return answer.ToArray();
    }
}
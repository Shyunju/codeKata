using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        List<int> answers = new List<int>();
        int[] exist = new int[1000000];
        
        for (int i = 1; i <= elements.Length; i++) {
            for (int j = 0; j < elements.Length; j++) {
                int sum = 0;
                for (int k = 0; k < i; k++) {
                    if (j + k >= elements.Length) {
                        sum += elements[j + k - elements.Length];
                    }
                    else
                        sum += elements[j + k];
                }
                if (exist[sum] == 0) {
                    answers.Add(sum);
                    exist[sum] = 1;
                }
            }
        }
        
        answer = answers.Count;
        return answer;
    }
}
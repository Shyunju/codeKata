using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answer = new List<int>();
        foreach(int i  in arr){
            if(i % divisor == 0)
                answer.Add(i);
        }
        if(answer.Count == 0){
            int[] none = {-1};
            return none;
        }
        answer.Sort();
        return answer.ToArray();
    }
}
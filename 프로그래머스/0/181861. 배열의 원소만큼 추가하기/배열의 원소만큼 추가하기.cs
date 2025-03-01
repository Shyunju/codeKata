using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        var answer = new List<int>();
        foreach(int i in arr){
            for(int j = 0; j < i; j++){
                answer.Add(i);
            }
        }
        return answer.ToArray();
    }
}
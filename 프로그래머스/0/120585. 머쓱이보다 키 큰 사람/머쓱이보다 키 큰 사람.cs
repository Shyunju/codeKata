using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        foreach(int i in array)
        {
            if(i > height)
                answer++;
        }
        return answer;
    }
}
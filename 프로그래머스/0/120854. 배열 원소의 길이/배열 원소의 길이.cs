using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[strlist.Length];
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = strlist[i].Length;
        }
        return answer;
    }
}
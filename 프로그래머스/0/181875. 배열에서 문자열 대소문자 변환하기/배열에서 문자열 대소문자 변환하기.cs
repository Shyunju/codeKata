using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[strArr.Length];
        for(int i = 0; i < answer.Length; i++){
            if(i % 2 == 0)
                answer[i] = strArr[i].ToLower();
            else
                answer[i] = strArr[i].ToUpper();
        }
        return answer;
    }
}
using System;
public class Solution {
    public string solution(string[] seoul) {
        int answer = 0;
        answer = Array.FindIndex(seoul, i => i == "Kim");
        
        return string.Format("김서방은 {0}에 있다", answer);
    }
}
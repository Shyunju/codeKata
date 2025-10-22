using System;
public class Solution {
    public string solution(string[] seoul) {
        int idx = Array.IndexOf(seoul, "Kim");
        string answer = "김서방은 " + idx + "에 있다";
        return answer;
    }
}
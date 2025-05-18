using System;

public class Solution {
    public string[] solution(string myStr) {
        char[] separators = new char[3]{ 'a', 'b', 'c' };
        string[] answer = myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        return answer.Length == 0 ? new string[1]{ "EMPTY" } : answer; 
    }
}
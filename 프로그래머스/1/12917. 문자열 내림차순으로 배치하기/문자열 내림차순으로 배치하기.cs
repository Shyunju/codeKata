using System;
class Solution {
    public string solution(string s) {
        char[] chr = s.ToCharArray();
        Array.Sort(chr);
        Array.Reverse(chr);
        string answer = new string(chr);
        return answer;
    }
}
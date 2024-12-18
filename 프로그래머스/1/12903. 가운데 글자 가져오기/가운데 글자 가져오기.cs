public class Solution {
    public string solution(string s) {
        string answer = s.Length % 2 == 0 ? s.Substring(s.Length/2 -1, 2) : s[s.Length/2].ToString();
        return answer;
    }
}
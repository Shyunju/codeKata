public class Solution {
    public string solution(string s) {
        string answer = "";
        if(s.Length % 2 == 0)
        {
            answer += s[s.Length / 2 -1].ToString();
        }
        answer += s[s.Length / 2].ToString();
        return answer;
    }
}
public class Solution {
    public string solution(string s) {
        int idx = s.Length /2;
        string answer = "";
        if( s.Length % 2 == 0){
            answer += s[idx -1];
            answer += s[idx];
        }else{
            answer += s[idx];
        }
        return answer;
    }
}
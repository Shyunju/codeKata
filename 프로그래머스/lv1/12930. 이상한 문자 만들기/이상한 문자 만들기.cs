public class Solution {
    public string solution(string s) {
        string answer = "";
        int wordIdx =0;
        for( int i = 0; i< s.Length ; i++){
            if( s[i] == ' '){
                wordIdx =0;
                answer += " ";
                continue;
            }
            if( wordIdx % 2 == 0 ){
                answer += s[i].ToString().ToUpper();
                wordIdx++;
            }else{
                answer += s[i].ToString().ToLower();
                wordIdx++;
            }
        }
        return answer;
    }
}
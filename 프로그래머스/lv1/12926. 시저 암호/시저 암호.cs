using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        for( int i = 0; i < s.Length; i++){
            char value = s[i];
            int plus = n % 26;
            if(value == ' '){
                answer += " ";
                continue;
            }
            value = Convert.ToChar(value + plus);    //대문자가 소문자영역안에 들어갔을 경우x
            if( s[i] <= 90 && value >= 97){
                value = Convert.ToChar(value - 26);
                answer += value.ToString();
                continue;
            }
            if(value < 97 && value > 90){
                value = Convert.ToChar(value - 26);
            }
            if(value > 122){
                value = Convert.ToChar(value - 26);
            }
            answer += value.ToString();
        }
        return answer;
    }
}
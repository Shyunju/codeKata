using System;
public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        // Split()은 문자열을 잘라주고 현재 공백을 기준으로 자름
        foreach(string a in letter.Split(" "))
        {
            // IndexOf()는 동일한 문자열이 존재할 경우 문자열의 위치를 반환한다. 문자열의 위치에 97을 더해 Covert.ToChar()로 변환하면 그에 맞는 문자로 변환된다.
            answer += Convert.ToChar(Array.IndexOf(mos, a) + 97);
        }
        return answer;
    }
}
using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        int len = strings.Length;
        string[] answer = new string[len];
        
        //각 문자열의 n번째 글자를 앞으로 더한 문자열을 저장
        for(int i=0; i<len; i++)
        {
            answer[i] = (strings[i][n]) + strings[i];
        }
        
        //오름차순 정렬
        Array.Sort(answer);
        
        //정렬된 문자열에 더했던 n번째 글자를 Substring(1)으로 제거
        for(int j=0; j<len; j++)
        {
            answer[j] = answer[j].Substring(1);
        }
        
        return answer;
    }
}
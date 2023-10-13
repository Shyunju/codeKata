using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;

    int firstCount = 0;
    int otherCount = 0;
    char first;

    first = s[0];
    int i;

    //주어진 문자열 순회
    for (i = 0; i < s.Length - 1; i++)
    {
        if (first == s[i]) //첫 글자와 같으면 firstCount +1
            firstCount++;
        else               //첫 글자와 다르면 otherCount +1
            otherCount++;

        if (firstCount == otherCount) // 두 개의 카운터가 같을 경우
        {
            firstCount = 0;
            otherCount = 0;
            answer++;

            first = s[i + 1]; //다음 글자를 첫 글자로 설정
        }
    }
    
    //만약에 남은 글자수가 0개가 아닐 경우 나눌 수 있다는 문자열이 있다는 뜻
    if (s.Substring(i).Length != 0) //Substring()은 인자로 받은 인덱스~끝 문자열을 반환해줌
        answer++;

    return answer;
    }
}
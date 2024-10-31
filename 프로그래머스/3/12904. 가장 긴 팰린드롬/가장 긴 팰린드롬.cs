public class Solution {
    public int solution(string s) 
{
    int answer = 1;

    for(int i = 0; i < s.Length - 1; ++i)
    {
        // 홀수 구성 체크 aba
        Check(s, 1, i, i, ref answer);

        // 짝수 구성 체크 abba
        if(s[i] == s[i + 1])
            Check(s, 2, i, i + 1, ref answer);
    }

    return answer;
}

void Check(string s, int startCount, int left, int right, ref int answer)
{            
    int count = startCount;

    while(true)
    {
        if(--left < 0) break;
        if(++right >= s.Length) break;
        if(s[left] != s[right]) break;
        count += 2;
    }

    if(count > answer)
        answer = count;
}

}
using System.Linq;
using System.Text;

public class Solution {
    public string solution(long n, string[] bans) {
        //알파벳 소문자 11글자 이하
        //bans에 있는 문자들이 제거되었을때
        //n번째 문자열 리턴
        //26진수 느낌
        //bans의 문자열을 26진수로 변환
        //bans중 n보다 작은 개수 a만큼 n을 더해줘야함
        //bans중 n+a보다 작거나 같은수 b만큼 더해줘야함

        long[] list = bans.Select(e=>StrToLong(e)).OrderBy(e=>e).ToArray();

        foreach(var num in list){
            if(num <= n){
                n++;
            }
        }
        string answer = LongToStr(n);

        return answer;
    }

    private long StrToLong(string s)
    {
        long result = 0;
        foreach (char c in s)
        {
            int val = c - 'a' + 1;  // a->1, b->2, ..., z->26
            result = result * 26 + val;
        }
        return result;
    }

    public string LongToStr(long n){
        var sb = new StringBuilder();
        while(n > 0){
            long remain = (n-1) % 26;
            char c = (char)('a' + remain);
            sb.Insert(0, c);
            n = (n-1)/26;
        }
        return sb.ToString();
    }
}
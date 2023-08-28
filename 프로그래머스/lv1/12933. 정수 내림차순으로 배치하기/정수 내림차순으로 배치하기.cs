using System;

public class Solution {
    public long solution(long n) {
        char[] cArr = n.ToString().ToCharArray();
        Array.Sort(cArr);
        Array.Reverse(cArr);
        long answer = long.Parse(new string(cArr));
        return answer;
    }
}
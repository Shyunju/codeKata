using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = s1.Count(x => s2.Contains(x));
        return answer;
    }
}
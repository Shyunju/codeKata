using System;
using System.Linq;
public class Solution {
    public int solution(string before, string after) {
        int answer = String.Concat(before.OrderBy(x=>x)) == String.Concat(after.OrderBy(x=>x)) ? 1 : 0;
        return answer;
    }
}
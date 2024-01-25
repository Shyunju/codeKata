using System;
using System.Linq;

public class Solution {
    public string solution(string rsp) {
        string answer = String.Concat(rsp.Select(x => x == '2' ? '0' : x == '0' ? '5' : '2'));
        return answer;
    }
}
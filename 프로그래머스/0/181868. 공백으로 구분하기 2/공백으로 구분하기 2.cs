using System;
using System.Linq;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = my_string.Split(" ").Where(w => w.Length >= 1).ToArray();
        return answer;
    }
}
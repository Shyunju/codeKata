using System;

public class Solution {
    public string solution(string my_string, string alp) {
        return my_string.Replace(alp, alp.ToUpper());
    }
}
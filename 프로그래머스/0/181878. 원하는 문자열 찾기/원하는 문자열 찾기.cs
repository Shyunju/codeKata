using System;

public class Solution {
    public int solution(string myString, string pat) {
        String s = myString.ToLower();
        String find = pat.ToLower();
        
        return s.Contains(find) ? 1 : 0;
    }
}
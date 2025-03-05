using System;

public class Solution {
    public int solution(string myString, string pat) {
        string new_pat = "";
        for(int i = 0; i < pat.Length; i++){
            if(pat[i] == 'A')
                new_pat += "B";
            else
                new_pat += "A";
        }
        return myString.Contains(new_pat) ? 1 : 0;
    }
}
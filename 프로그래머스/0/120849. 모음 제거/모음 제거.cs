using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        
        List<char> chars = new List<char>();
        char[] vowel = new char[] {'a', 'e', 'i', 'o' ,'u'};
        char[] original = my_string.ToCharArray();
        
        for(int i = 0; i<original.Length; i++)
        {
            if(Array.Exists(vowel, x => x == original[i]))
                continue;
            chars.Add(original[i]);
        }
        string answer = string.Join("", chars);
        return answer;
    }
}
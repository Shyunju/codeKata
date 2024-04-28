using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        List<string> words = new List<string>();
        StringBuilder word = new StringBuilder();
        int count = 0;
        
        for(int i = 0; i < my_str.Length; i++)
        {
            word.Append(my_str[i]);
            count++;
            if(count % n == 0)
            {
                words.Add(word.ToString());
                count = 0;
                word.Clear();
            }
        }
        if(word.Length > 0)
            words.Add(word.ToString());
        
        return answer = words.ToArray();
    }
}
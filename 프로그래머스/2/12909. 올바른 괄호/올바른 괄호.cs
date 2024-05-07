using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        
        Stack<string> stack = new Stack<string>();
        if(s[0].ToString().Equals(")"))
            return false;
        
        foreach(char i in s)
        {
            string item = i.ToString();
            if(item.Equals("("))
                stack.Push(item);
            else if(item.Equals(")") && stack.Count > 0)
                stack.Pop();
        }
        return stack.Count == 0 ? true : false;
    }
}
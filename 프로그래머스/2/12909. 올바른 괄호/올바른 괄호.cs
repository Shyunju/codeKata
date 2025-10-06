using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
        char[] parenthesis = s.ToCharArray();
        
        Stack<char> stk = new Stack<char>();
        foreach(char i in parenthesis)
        {
            if(i == '(')
            {
                stk.Push(i);
                continue;
            }
            if(stk.Count == 0)
                return false;
            stk.Pop();                
        }
        if(stk.Count > 0)
            return false;
        return true;
    }
}
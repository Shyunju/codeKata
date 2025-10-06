using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
        Stack<char> stk = new Stack<char>();
        foreach(char i in s)
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
        return stk.Count > 0 ? false : true;
    }
}
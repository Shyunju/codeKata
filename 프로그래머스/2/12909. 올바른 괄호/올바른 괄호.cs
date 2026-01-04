using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
        Stack<char> a = new Stack<char>();
        foreach(char c in s)
        {
            if(c == ')')
            {
                if(a.Count < 1)
                    return false;
                char last = a.Pop();
                if(last != '(')
                    return false;
            }
            else
                a.Push(c);
        }
        if(a.Count > 0)
            return false;
        return true;
    }
}
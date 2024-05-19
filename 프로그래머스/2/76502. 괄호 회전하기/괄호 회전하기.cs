using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        List<char> str = new List<char> (s);
        for (int i = 0; i < s.Length; i++)
        {
            answer += isProperBrackets(str) ? 1 : 0;
            str.Add(str[0]);
            str.RemoveAt(0);
        }
        
        return answer;
    }
    private bool isProperBrackets(List<char> str)
    {
        Stack<char> brackets = new Stack<char> ();
        string open = "({[";
        string close = ")}]";
        
        for (int i = 0; i < str.Count; i++)
        {
            if (open.Contains(str[i]))
                brackets.Push(str[i]);
            else
            {
                if (brackets.Count == 0)
                    return false;
                if (str[i] != close[open.IndexOf(brackets.Peek())])
                    return false;
                brackets.Pop();
            }
        }
        if (brackets.Count != 0)
            return false;
        return true;
    }
}
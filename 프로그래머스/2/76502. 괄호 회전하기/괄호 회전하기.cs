using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        List<char> str = new List<char>(s);
        if(str.Count % 2 == 1)
            return 0;
        for(int i = 0; i < str.Count; i++)
        {
            answer += CheckBraket(str) ? 1 : 0;
            str.Add(str[0]);
            str.RemoveAt(0);
        }
        return answer;
    }
    
    private bool CheckBraket(List<char> str)
    {
        string open = "({[";
        string close = ")}]";
        Stack<char> bracket = new Stack<char>();
        for(int i = 0; i < str.Count; i++)
        {
            if(open.Contains(str[i]))
            {
                bracket.Push(str[i]);
                continue;
            }
            if(bracket.Count == 0)
                return false;
            if(str[i] != close[open.IndexOf(bracket.Peek())])
                return false;
            
            bracket.Pop();
        }
        return bracket.Count > 0 ? false : true;
    }
}
using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        List<char> str = new List<char>(s);
        for(int i = 0; i < s.Length; i++)
        {
            answer += isCollect(str) ? 1 : 0;
            str.Add(str[0]);
            str.RemoveAt(0);
        }
        return answer;
    }
    
    public bool isCollect(List<char> str)
    {
        string open = "({[";
        string close = ")}]";
        
        Stack<char> stack = new Stack<char>();
        
        for(int i = 0; i <str.Count; i++)
        {
            if(open.Contains(str[i]))
                stack.Push(str[i]);
            else{
                if(stack.Count == 0)
                    return false;
                if(str[i] != close[open.IndexOf(stack.Peek())])
                    return false;
                
                stack.Pop();
            }
        }
        
        if(stack.Count != 0)
            return false;
        return true;
    }
}
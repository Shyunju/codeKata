using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string[] solution(string[] s) {
        string[] answer = new string[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            answer[i] = GetTransformedString(s[i]); 
        }
    
        return answer;
    }
    
    public string GetTransformedString(string s)
    {
        if (s.Length < 3) return s;
        // list로도 할 수 있을것같기도..?
        Stack<char> stack = new Stack<char>();
        int targetCount = 0; // 110 개수
        int oneCount = 0; // 남은 문자에 대해 뒤에서부터 연속되는 1의 개수
     
        for (int i = 0; i < s.Length; i++)
        {
            char currentS = s[i];
            
            if (stack.Count < 2)
            {
                stack.Push(currentS);
                continue;
            }
            
            char prevS = stack.Pop();
            char prevprevS = stack.Peek();
            
            if (prevprevS == '1' && prevS == '1' && currentS == '0')
            {
                targetCount += 1;
                stack.Pop(); // prevprev도 제거
            }
            else
            {
                stack.Push(prevS); // 뺐었던 prev S 넣기
                stack.Push(currentS); // 현재 S 넣기
            }
        }
        
        List<char> remainChars = stack.ToList(); // 순서 top -> bottom 순으로 list 만들어짐
        
        for (int i = 0; i < remainChars.Count; i++)
        {
            if (remainChars[i] != '1') break;
            oneCount += 1;
        }
        
        StringBuilder sb = new StringBuilder();
        for (int i = remainChars.Count - 1; i >= oneCount; i--)
        {
            sb.Append(remainChars[i]);
        }
        
        string transformedString = "";
        transformedString += sb.ToString();
        transformedString += String.Concat(Enumerable.Repeat("110", targetCount));
        transformedString += new String('1', oneCount);
        
        return transformedString;
    }
}
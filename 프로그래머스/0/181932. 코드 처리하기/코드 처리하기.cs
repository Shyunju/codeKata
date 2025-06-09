using System;
using System.Text;
public class Solution {
    public string solution(string code) {
        var sb = new StringBuilder();
        bool mode = true;
        for(int i = 0; i < code.Length; i++)
        {
            if(code[i] == '1'){
                mode = !mode;
                continue;
            }
            if(mode)
            {
                if(i % 2 == 0)
                    sb.Append(code[i]);
                    
            }else{
                if(i % 2 == 1)
                    sb.Append(code[i]);
            }
        }
        
        string answer = sb.Length == 0 ? "EMPTY" : sb.ToString();
        
        return answer;
        
    }
}
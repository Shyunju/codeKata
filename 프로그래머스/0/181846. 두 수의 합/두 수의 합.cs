using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string solution(string a, string b) {
        int up = 0;
        int max = Math.Max(a.Length, b.Length);
        List<string> answer = new List<string>();
        if(a.Length != max)
            a = a.PadLeft(max, '0');
        if(b.Length != max)
            b = b.PadLeft(max, '0');
        for(int i = max -1; i >= 0; i--)
        {            
            int num1 = int.Parse(a[i].ToString());
            int num2 = int.Parse(b[i].ToString());
            
            int fix = (num1 + num2 + up) % 10;
            up = (num1 + num2 + up) / 10;
            
            answer.Add(fix.ToString());
        }
        if(up > 0)  answer.Add(up.ToString());
        answer.Reverse();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < answer.Count; i++)
        {
            sb.Append(answer[i]);
        }
        return sb.ToString();
    }
}
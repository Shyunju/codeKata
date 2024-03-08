using System;
using System.Text;

public class Solution {
    public string solution(int q, int r, string code) {
        StringBuilder answer = new StringBuilder();

        for(int i =0; i<code.Length; i++)
        {
            if(i % q == r)
            {
                answer.Append(code[i]);
            }
        }
        return answer.ToString();
    }
}
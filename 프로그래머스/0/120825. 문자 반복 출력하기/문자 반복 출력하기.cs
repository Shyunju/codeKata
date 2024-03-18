using System;
using System.Text;
public class Solution {
    public string solution(string my_string, int n) {
        StringBuilder answer = new StringBuilder();
        for(int i = 0; i <my_string.Length; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                answer.Append(my_string[i]);
            }
        }
        string result = answer.ToString();
        return result;
    }
}
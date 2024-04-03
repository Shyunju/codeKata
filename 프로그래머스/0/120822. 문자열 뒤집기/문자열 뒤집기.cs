using System;
using System.Text;
public class Solution {
    public string solution(string my_string) {
        StringBuilder sb = new StringBuilder();
        for(int i = my_string.Length -1; i >= 0; i--)
        {
            sb.Append(my_string[i]);
        }
        string answer = sb.ToString();
        return answer;
    }
}
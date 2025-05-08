using System;
using System.Text;
public class Solution {
    public string solution(string str1, string str2) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < str1.Length; ++i)
        {
            sb.Append(str1[i].ToString());
            sb.Append(str2[i].ToString());
        }
        return sb.ToString();
    }
}
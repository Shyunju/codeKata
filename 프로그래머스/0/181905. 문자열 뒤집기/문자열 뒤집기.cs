using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int s, int e) {
        if(s == e)
            return my_string;
        char[] charArr = my_string.Substring(s, e -s+1).ToCharArray();
        Array.Reverse(charArr);
        string reverse = new string(charArr);
        StringBuilder sb = new StringBuilder();
        sb.Append(my_string.Substring(0, s));
        sb.Append(reverse);
        sb.Append(my_string.Substring(e+1));
        return sb.ToString();
                  
    }
}
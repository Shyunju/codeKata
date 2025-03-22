using System;
using System.Text;
public class Solution {
    public string solution(string[] str_list, string ex) {
        StringBuilder sb = new StringBuilder();
        foreach(string i in str_list)
        {
            if(!i.Contains(ex))
            {
                sb.Append(i);
            }
        }
        if(sb.Length == 0)  return "";
        return sb.ToString();
    }
}
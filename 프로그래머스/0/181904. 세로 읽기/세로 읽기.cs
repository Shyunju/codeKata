using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string solution(string my_string, int m, int c) {
        var strList = new List<string>();
        for(int i = 0; i < my_string.Length; i += m)
        {
            strList.Add(my_string.Substring(i, m));
        }
        StringBuilder sb = new StringBuilder();
        foreach(var i in strList){
            sb.Append(i[c-1]);
        }
        return sb.ToString();
    }
}
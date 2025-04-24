using System;
using System.Text;
public class Solution {
    public string solution(string myString) {
        StringBuilder sb = new StringBuilder();
        foreach(var i in myString)
        {
            if(i < 'l')
                sb.Append("l");
            else
                sb.Append(i.ToString());
        }
        return sb.ToString();
    }
}
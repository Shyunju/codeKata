using System;
using System.Text;
public class Solution {
    public string solution(string[] arr) {
        StringBuilder sb = new StringBuilder();
        foreach(var i in arr)
        {
            sb.Append(i);
        }
        return sb.ToString();
    }
}
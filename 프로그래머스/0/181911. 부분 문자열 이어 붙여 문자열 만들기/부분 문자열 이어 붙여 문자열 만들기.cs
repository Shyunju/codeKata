using System;
using System.Text;
public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < my_strings.Length; i++)
        {
            for(int j = parts[i,0]; j <= parts[i,1]; j++)
            {
                sb.Append(my_strings[i][j]);
            }
        }
        return sb.ToString();
    }
}
using System;
using System.Text;
public class Solution {
    public string solution(string my_string, int[] index_list) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < index_list.Length; i++)
        {
            sb.Append(my_string[index_list[i]]);
        }
        return sb.ToString();
    }
}
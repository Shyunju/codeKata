using System;
using System.Text;
public class Solution {
    public string solution(string my_string, int k) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<k; ++i){
            sb.Append(my_string);
        }
        return sb.ToString();
    }
}
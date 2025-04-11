using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        if(is_suffix.Length > my_string.Length) return 0;
        string str = my_string.Substring(my_string.Length - is_suffix.Length);
        return str == is_suffix ? 1 : 0;
    }
}
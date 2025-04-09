using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        
        if(my_string.Length < is_prefix.Length)
            return 0;
        int min = my_string.Length < is_prefix.Length ? my_string.Length : is_prefix.Length;
        for(int i = 0; i < min; i++)
        {
            if(my_string[i] != is_prefix[i])
                return 0;
        }
        return 1;
    }
}
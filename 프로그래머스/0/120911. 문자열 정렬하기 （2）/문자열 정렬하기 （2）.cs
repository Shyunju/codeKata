using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] lower = my_string.ToCharArray();
        for(int i = 0; i < lower.Length; i++){
            if(!Char.IsLower(lower[i]))
            {
                lower[i] = Char.ToLower(lower[i]);
            }
        }
        Array.Sort(lower);
        return answer = new string(lower);
    }
}
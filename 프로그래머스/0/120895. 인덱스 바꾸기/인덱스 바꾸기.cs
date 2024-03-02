using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        char[] result = my_string.ToCharArray();
        char tmp = result[num1];
        result[num1] = result[num2];
        result[num2] = tmp;
        return answer = String.Join("", result);
    }
}
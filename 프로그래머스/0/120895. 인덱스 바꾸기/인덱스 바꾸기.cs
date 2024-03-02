using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        StringBuilder stb=new StringBuilder(my_string);
        stb[num1]=my_string[num2];
        stb[num2]=my_string[num1];
        answer=stb.ToString();
        return answer;
    }
}
using System;
using System.Text;
public class Solution {
    public string solution(string my_string) {
        StringBuilder answer = new StringBuilder();
        foreach(char ch in my_string){
            if(ch >=97)
                answer.Append(ch.ToString().ToUpper());
            else
                answer.Append(ch.ToString().ToLower());
        }
        return new string(answer.ToString());
    }
}
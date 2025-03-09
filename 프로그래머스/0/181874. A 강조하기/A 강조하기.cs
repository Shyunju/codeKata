using System;
using System.Text;
public class Solution {
    public string solution(string myString) {
        StringBuilder answer = new StringBuilder();
        foreach(var i in myString){
            if(i == 'a' || i == 'A')
                answer.Append("A");
            else
                answer.Append(i.ToString().ToLower());
        }
        return answer.ToString();
    }
}
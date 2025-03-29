using System;
using System.Text;

public class Solution {
    public string solution(string n_str) {
        StringBuilder sb = new StringBuilder();
        bool isZero = true;
        foreach(char i in n_str)
        {
            if(i == '0' && isZero)  continue;
            else if(isZero){
                isZero = false;
            }
            sb.Append(i.ToString());
        }
        return sb.ToString();
    }
}
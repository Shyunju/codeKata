using System;

public class Solution {
    public int solution(string binomial) {
        string[] cal = {"+", "-", "*"};
        string op = "";
        int opIdx = 0;
        for(int i = 0; i < binomial.Length; i++){
            if(Array.IndexOf(cal, binomial[i].ToString()) >= 0){
                op = binomial[i].ToString();
                opIdx = i;
                break;
            }
        }
        int a = int.Parse(binomial.Substring(0, opIdx));
        int b = int.Parse(binomial.Substring(opIdx+1));
        switch(op){
            case "+":
                return a + b;
                break;
            case "-":
                return a - b;
                break;
            case "*":
                return a * b;
                break;
            default:
                return 0;
                break;
        }
    }
}
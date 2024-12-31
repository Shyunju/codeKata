using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] expressions) {
        string[] answer = new string[] {};
        var listAns = new List<string>();
        var hint = new List<string>();
        var answerFormat = new List<int>();
        int maxFormat = 0;
        
        foreach(var e in expressions){
            var part = e.Split(' ');
            string num1 = part[0], num2 = part[2], ans = part[4];
            
            foreach(char ch in num1) maxFormat = Math.Max(maxFormat, (int)char.GetNumericValue(ch));
            foreach(char ch in num2) maxFormat = Math.Max(maxFormat, (int)char.GetNumericValue(ch));
            
            if(ans != "X"){
                hint.Add(e);
                foreach(char ch in ans) maxFormat = Math.Max(maxFormat, (int)char.GetNumericValue(ch));
            }else
                listAns.Add(e);
        }
        for(int n = maxFormat + 1; n <= 9; n++){
            bool check = true;
            foreach(var h in hint){
                var part = h.Split(' ');
                
                int num1 = NToTen(n, part[0]);
                int num2 = NToTen(n, part[2]);
                int ans = NToTen(n, part[4]);
                
                if((part[1] == "+" && num1 + num2 != ans) || (part[1] == "-" && num1 - num2 != ans)){
                    check = false;
                    break;
                }
            }
            if(check)
                answerFormat.Add(n);
        }
        for(int i = 0; i < listAns.Count; i++){
            var part = listAns[i].Split(' ');
            string num1 = part[0], num2 = part[2];
            var ansSet = new HashSet<string>();
            
            foreach(var a in answerFormat){
                int num_1 = NToTen(a, num1);
                int num_2 = NToTen(a, num2);
                if(part[1] == "+") ansSet.Add(TenToN(a, num_1 + num_2));
                if(part[1] == "-") ansSet.Add(TenToN(a, num_1 - num_2));
            }
            
            if(ansSet.Count == 1) 
                listAns[i] = string.Join(" ",num1,part[1],num2,"=", ansSet.First());
            else
                listAns[i] = string.Join(" ",num1,part[1],num2,"=","?");
        }
        answer = listAns.ToArray();
        return answer;
    }
    int NToTen(int n, string num)
    {
        if (num.Length == 1) return int.Parse(num);

        int number = 0;
        for (int idx = 0; idx < num.Length; idx++)
        {
            number += (int)(char.GetNumericValue(num[idx]) * Math.Pow(n, num.Length - 1 - idx));
        }

        return number;
    }
    string TenToN(int n, int num){
        if(num == 0)  return "0";
        string result = "";
        
        while(num > 0){
            int remainder = num % n;
            result = remainder.ToString() + result;
            num /= n;
        }
        return result;
    }
}
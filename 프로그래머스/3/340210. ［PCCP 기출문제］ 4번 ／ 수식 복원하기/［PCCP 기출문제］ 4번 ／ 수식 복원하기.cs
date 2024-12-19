using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public      string[] solution(string[] expressions)
     {
         string[] answer = new string[] { };

         List<string> list_Ans = new List<string>();
         List<string> hint = new List<string>();
         List<int> answerFormat = new List<int>();

         int maxFormat = 0;
         foreach (var e in expressions)
         {
             var parts = e.Split(' ');
             string num1 = parts[0], num2 = parts[2], ans = parts[4];

             foreach (var ch in num1) maxFormat = Math.Max(maxFormat, (int)char.GetNumericValue(ch));
             foreach (var ch in num2) maxFormat = Math.Max(maxFormat, (int)char.GetNumericValue(ch));

             if (ans != "X")
             {
                 hint.Add(e);
                 foreach (var ch in ans) maxFormat = Math.Max(maxFormat, (int)char.GetNumericValue(ch));
             }
             else
             {
                 list_Ans.Add(e);
             }
         }

         for (int n = maxFormat + 1; n <= 9; n++)
         {
             bool check = true;
             foreach (var h in hint)
             {
                 var parts = h.Split(' ');
                 int num1 = NToTen(n, parts[0]);
                 int num2 = NToTen(n, parts[2]);
                 int ans = NToTen(n, parts[4]);
                 if ((parts[1] == "+" && num1 + num2 != ans) || (parts[1] == "-" && num1 - num2 != ans))
                 {
                     check = false;
                     break;
                 }
             }

             if (check) answerFormat.Add(n);
         }

         for (int i = 0; i < list_Ans.Count; i++)
         {
             var parts = list_Ans[i].Split(' ');
             string num1 = parts[0], num2 = parts[2];
             var ansSet = new HashSet<string>();

             foreach (var a in answerFormat)
             {
                 int num_1 = NToTen(a, num1);
                 int num_2 = NToTen(a, num2);

                 if (parts[1] == "+") ansSet.Add(TenToN(a, num_1 + num_2));
                 if (parts[1] == "-") ansSet.Add(TenToN(a, num_1 - num_2));
             }

             if (ansSet.Count == 1)
             {
                 list_Ans[i] = string.Join(" ", num1, parts[1], num2, "=", ansSet.First());
             }
             else
             {
                 list_Ans[i] = string.Join(" ", num1, parts[1], num2, "=", "?");
             }
         }

         answer = list_Ans.ToArray();
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

string TenToN(int n, int num)
{
    if (num == 0) return "0";

    string answer = "";
    for (int idx = 2; idx >= 0; idx--)
    {
        int div = num / (int)Math.Pow(n, idx);
        if (answer.Length > 0 || div > 0) answer += div.ToString();
        num %= (int)Math.Pow(n, idx);
    }

    return answer;
}
}
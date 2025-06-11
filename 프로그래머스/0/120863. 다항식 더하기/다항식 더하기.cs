using System;
using System.Linq;
public class Solution {
    public string solution(string polynomial) {
        string[] answer = polynomial.Split(" ");
        string result = "";
        string str = "";
        int xNum = 0;
        int num = 0;
        for (int i = 0; i < answer.Length; i += 2)
        {
            if (answer[i].Contains("x"))
            {
                str = answer[i].Replace("x", string.Empty);
                if (str == "")
                {
                    str = "1";
                }
                xNum += Convert.ToInt32(str);
            }
            else
                num += Convert.ToInt32(answer[i]);
        }
        if (num == 0)
        {
            if(xNum ==1)
                result = "x";
            else
                result = xNum + "x";
        }
        else
        {
            if(xNum ==0)
                result = num.ToString();
            else if(xNum ==1)
            {
                result = "x " + "+ " + num;
            }
            else
                result = xNum + "x " + "+ " + num;
        }
        return result;
    }
}
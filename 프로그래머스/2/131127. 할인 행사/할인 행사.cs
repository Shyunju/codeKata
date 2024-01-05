using System;
using System.Collections.Generic;

public class Solution
{
    Dictionary<string, int> dic = new Dictionary<string, int>();
    public int solution(string[] want, int[] number, string[] discount)
    {
        int answer = 0;
        InsertData(want, number);
				
        answer=FirstCheck(dic,discount);
        
        for (int i = 1; i < discount.Length-9; i++)
        {

            if (dic.ContainsKey(discount[i - 1]))
            {
                dic[discount[i - 1]]++;
            }
            if (dic.ContainsKey(discount[i + 9]))
            {
                dic[discount[i + 9]]--;
            }
            if (CheckNumber(dic))
            {
                answer++;
            }
        }
        return answer;
    }

    void InsertData(string[] want, int[] number)
    {
        for (int i = 0; i < want.Length; i++)
        {
            dic[want[i]] = number[i];
        }
    }

    int FirstCheck(Dictionary<string, int> dic,string[] discount)
    {
        int answer = 0;
        for (int i = 0; i < 10; i++)
        {
            if (dic.ContainsKey(discount[i]))
            {
                dic[discount[i]]--;
            }
        }
        if (CheckNumber(dic))
        {
            answer++;
        }
        return answer;
    }
    
    bool CheckNumber(Dictionary<string, int> _dic)
    {
        bool b = false;
        foreach (int i in _dic.Values)
        {
            if (i > 0)
            {
                b = false;
                break;
            }
            else { b = true; }
        }
        return b;
    }
}
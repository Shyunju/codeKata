using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    Dictionary<string, int> wantDict;
    Dictionary<string, int> currentDict;
    string[] discount;
    public int solution(string[] want, int[] number, string[] discount) 
    {
        int answer = 0;
        wantDict = new Dictionary<string, int>();
        currentDict = new Dictionary<string, int>();
        this.discount = discount;
        for (int i = 0; i < want.Length; i++) 
        {
            wantDict[want[i]] = number[i];
        }
        for (int i = 0; i < 10; i++) 
        {
            currentDict[discount[i]] = currentDict.GetValueOrDefault(discount[i], 0) + 1;
        }
        

        if (IsMatch()) 
            answer++;

        for (int i = 1; i <= discount.Length - 10; i++) 
        {
            // 나가는 원소 (i-1번째)
            string outItem = discount[i - 1];
            currentDict[outItem]--;
            
            // 들어오는 원소 (i+9번째)
            string inItem = discount[i + 9];
            currentDict[inItem] = currentDict.GetValueOrDefault(inItem, 0) + 1;

            if (IsMatch()) 
                answer++;
        }

        return answer;
    }
    public bool IsMatch() 
    {
        foreach (var pair in wantDict) 
        {
            if (currentDict.GetValueOrDefault(pair.Key, 0) != pair.Value) 
                return false;
        }
        return true;
    }
}
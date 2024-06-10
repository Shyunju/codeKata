using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        Dictionary<char, int> dic = new Dictionary<char, int>();
        
        int year = int.Parse(today.Substring(0,4));
        int month = int.Parse(today.Substring(5,2));
        int day = int.Parse(today.Substring(8));
        
        for(int i = 0; i < terms.Length; i++)
        {
            char type = terms[i][0];
            int during = int.Parse(terms[i].Substring(2));
            
            dic.Add(type, during);
        }
        for(int i = 0; i < privacies.Length; i++)
        {
            int y = int.Parse(privacies[i].Substring(0,4));
            int m = int.Parse(privacies[i].Substring(5,2));
            int d = int.Parse(privacies[i].Substring(8,2));
            
            char type = privacies[i][privacies[i].Length -1];
            
            m += dic[type];
            if(m >= 12)
            {
                y += m /12;
                m %= 12;
                if(m == 0){
                    --y;
                    m = 12;
                }
            }
            if( y <= year){
                if(y < year){
                    answer.Add(i+1);
                    continue;
                }
                if( m <= month){
                    if(m < month){
                        answer.Add(i+1);
                        continue;
                    }
                    if(d <= day)
                        answer.Add(i+1);
                }
            }
        }
        return answer.ToArray();
    }
}
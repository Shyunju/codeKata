using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount) {
        var enrollDict = Enumerable.Range(0, enroll.Length).ToDictionary(e => enroll[e], e => referral[e]);
        var moneyDict = Enumerable.Range(0, enroll.Length).ToDictionary(e => enroll[e], e => 0);
        
        for(int i = 0; i < seller.Length; i++){
            string name = seller[i];
            int money = amount[i] * 100;
            
            while(true){
                int tenpercent = (int)Math.Floor(money * 0.1);
                moneyDict[name] += money - tenpercent;
                
                if(tenpercent == 0) break;
                if(enrollDict[name] == "-") break;
                
                name = enrollDict[name];
                money = tenpercent;
            }
        }
        return enroll.Select(s => moneyDict[s]).ToArray();
    }
}
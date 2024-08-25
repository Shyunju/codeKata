using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public class User{
        public int ratio;
        public int over;
    }
    public class Emoticon {
        public int origin;
        public int persent;
        public int GetSalePrice() => origin * (100 - persent) / 100; 
    }
    public int[] solution(int[,] users, int[] emoticons) {
        User[] arr = Enumerable.Range(0, users.GetLength(0))
            .Select(s => new User{ratio = users[s,0], over = users[s,1]}).ToArray();
        
        Emoticon[] emo = emoticons.Select(s => new Emoticon{origin = s}).ToArray();
        
        int joinPlus = 0;
        int sales = 0;
        DFS(0, arr, emo, ref joinPlus, ref sales);
        return new int[2]{joinPlus, sales};
    }
    void DFS(int idx, User[] users, Emoticon[] emo, ref int joinPlus, ref int sales){
        if(idx == emo.Length){
            int curJoinPlus = 0;
            int curSales = 0;
            
            foreach(User user in users){
                int total = emo.Where(w => w.persent >= user.ratio)
                    .Select(s => s.GetSalePrice())
                    .Sum();
                
                if(total >= user.over)
                    ++curJoinPlus;
                else
                    curSales += total;
            }
            
            if(joinPlus < curJoinPlus){
                joinPlus = curJoinPlus;
                sales = curSales;
            }else if(joinPlus == curJoinPlus){
                if(sales < curSales)
                    sales = curSales;
            }
            return;
        }
        for(int k = 10; k <= 40; k += 10){
            emo[idx].persent = k;
            DFS(idx +1, users, emo, ref joinPlus, ref sales);
        }
    }
}
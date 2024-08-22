using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public class User
    {
        public int ratio;
        public int over;
    }

    public class Emoticon
    {
        public int originPrice;
        public int saleRatio; // 10, 20, 30, 40
        public int GetSalePrice() => originPrice * (100 - saleRatio) / 100;
    }

    public int[] solution(int[,] users, int[] emoticons) 
    {
        User[] arr = Enumerable.Range(0, users.GetLength(0))
                            .Select(s => new User{ ratio = users[s, 0], over = users[s, 1] })
                            .ToArray();

        Emoticon[] emo = emoticons.Select(s => new Emoticon{ originPrice = s })
                                  .ToArray();

        int plusCount = 0;
        int sales = 0;
        DFS(0, arr, emo, ref plusCount, ref sales);
        return new int[2] { plusCount, sales };
    }

    void DFS(int index, User[] users, Emoticon[] emo, ref int plusCount, ref int sales)
    {
        if(index == emo.Length)
        {
            int curPlusCount = 0;
            int curSales = 0;
            foreach(User user in users)
            {
                int userSpendMoney = emo.Where(w => w.saleRatio >= user.ratio)
                                       .Select(s => s.GetSalePrice())
                                       .Sum();

                if(userSpendMoney >= user.over) 
                    ++curPlusCount;
                else 
                    curSales += userSpendMoney;
            }

            if(plusCount < curPlusCount)
            {
                plusCount = curPlusCount;
                sales = curSales;
            }
            else if(plusCount == curPlusCount)
            {
                if(sales < curSales)
                    sales = curSales;
            }

            return;
        }

        for(int k = 10; k <= 40; k += 10) // 할인 폭은 10% ~ 40% 고정임
        {
            emo[index].saleRatio = k; // 할인
            DFS(index + 1, users, emo, ref plusCount, ref sales);
        }
    }
}
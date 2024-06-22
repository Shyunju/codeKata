using System;

public class Solution {
    public int solution(string[,] book_time) {
        var length = 24 * 60 + 10;
        int answer = 0;

        var stores = new int[length];
        for(int i = 0; i < book_time.GetLength(0); i++)
        {
            var ss = book_time[i, 0].Split(":");
            var s = int.Parse(ss[0]) * 60 + int.Parse(ss[1]);
            var ee = book_time[i, 1].Split(":");
            var e = int.Parse(ee[0]) * 60 + int.Parse(ee[1]);


            stores[s] += 1;
            stores[e + 10] += -1;
        }

        for(int i = 1; i < length; i++)
        {
            stores[i] += stores[i - 1];
            answer = Math.Max(answer, stores[i]);
        }
        return answer;
}
}
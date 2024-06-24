using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[,] book_time) {
        List<(int, int)> rental = new List<(int inTime, int outTime)>();
        
        for(int i = 0; i < book_time.GetLength(0); i++){
            int inTime = toTime(book_time[i,0]);
            int outTime = toTime(book_time[i,1]);
            
            rental.Add((inTime, outTime));
        }
        var sorted = rental.OrderBy(o => o.Item1);
        List<int> roomList = new List<int>();
        
        foreach((int inTime, int outTime)t in sorted){
            int room = roomList.FindIndex(f => f <= t.inTime-10);
            
            if( room == -1)
                roomList.Add(t.outTime);
            else
                roomList[room] = t.outTime;            
        }
        return roomList.Count;
    }
    public int toTime(string time){
        string[] num = time.Split(':');
        return int.Parse(num[0]) * 60 + int.Parse(num[1]);
    }
}
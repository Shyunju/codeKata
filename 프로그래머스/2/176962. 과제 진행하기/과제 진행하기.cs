using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string[,] plans) {
        List<string> answer = new List<string>();
        var hold = new Stack<Table>();
        var homework = new Table[plans.GetLength(0)];
        
        for(int i = 0; i < plans.GetLength(0); i++)
            homework[i] = new Table(plans[i,0], plans[i,1], plans[i,2]);
        homework = homework.OrderBy(o => o.start).ToArray();
        
        int startIdx = 0;
        
        while(startIdx < plans.GetLength(0)){
            Table cur = homework[startIdx];
            bool isLast = startIdx +1 == plans.GetLength(0);
            int availableTime = isLast ? int.MaxValue : homework[startIdx + 1].start - cur.start;
            
            hold.Push(cur);
            
            while(hold.Count > 0){
                Table top = hold.Peek();
                
                if(availableTime >= top.need){
                    availableTime -= top.need;
                    answer.Add(top.name);
                    hold.Pop();
                    
                    if(availableTime == 0) break;
                }else{
                    top.need -= availableTime;
                    break;
                }
            }
            ++startIdx;
        }
        return answer.ToArray();
    }
}
public class Table{
    public string name;
    public int start;
    public int need;
    
    public Table(string name, string startTime, string needTime){
        this.name = name;
        string[] split = startTime.Split(':');
        start = int.Parse(split[0]) * 60 + int.Parse(split[1]);
        need = int.Parse(needTime);
    }
}
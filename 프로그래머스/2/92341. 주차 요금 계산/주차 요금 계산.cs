using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        
        Dictionary<string, List<string>> dicList = new Dictionary<string, List<string>>();
        List<int> answer = new List<int>();

        for (var i=0; i< records.Length; i++)
        {
            var tmp = records[i].Split(' ');
            var list = records.Where(w => w.Substring(6, 4) == tmp[1]).OrderBy(o => o);

            if(!dicList.ContainsKey(tmp[1]))
                dicList.Add(tmp[1], list.ToList());
        }

        var result = dicList.OrderBy(o => o.Key);
        double totalMinute = 0;
        foreach(var dic in result)
        {
            DateTime inTime = DateTime.Now;
            DateTime outTime = DateTime.Now;

            for (var i=0;   i< dic.Value.Count; i++ )
            {
                var values = dic.Value[i].Split(' ');
                string time = values[0];
                string gb = values[2];

                if (gb == "IN")
                    inTime = getTime(time);
                else
                {
                    outTime = getTime(time);

                    TimeSpan dateDiff = outTime - inTime;
                    totalMinute += Convert.ToInt32(dateDiff.TotalMinutes);
                }
            }

            if (dic.Value.Count % 2 != 0)
            {
                outTime = getTime("23:59");

                TimeSpan dateDiff = outTime - inTime;
                totalMinute += Convert.ToInt32(dateDiff.TotalMinutes);
            }

            double parkingPrice = fees[1];

            if(totalMinute > fees[0])
                parkingPrice += Math.Ceiling((totalMinute - fees[0]) / fees[2]) * fees[3];
            
            answer.Add(Convert.ToInt32(parkingPrice));

            totalMinute = 0;
        }

        return answer.ToArray();
    }
    private DateTime getTime(string time){
        return Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " " + time);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {

        List<string> newRecords = new List<string>();
        Dictionary<string, List<string>> dicList = new Dictionary<string, List<string>>();
        List<int> answerList = new List<int>();

        for (var i=0; i< records.Length; i++)
        {
            var tmp = records[i].Split(' ');
            var list = records.Where(w => w.Substring(6, 4) == tmp[1]).OrderBy(o => o);

            if(!dicList.ContainsKey(tmp[1]))
            {
                dicList.Add(tmp[1], list.ToList());
            }
        }

        var result = dicList.OrderBy(o => o.Key);
        double totalMinute = 0;
        foreach(var dic in result)
        {
            DateTime inTime = DateTime.Now;
            DateTime outTime = DateTime.Now;

            for (var i=0;   i< dic.Value.Count; i++ )
            {
                var time = dic.Value[i].Split(' ')[0];
                var gb = dic.Value[i].Split(' ')[2];

                if (gb == "IN")
                {
                    inTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " " + time);
                }
                else
                {
                    outTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " " + time);

                    TimeSpan dateDiff = outTime - inTime;
                    totalMinute += Convert.ToInt32(dateDiff.TotalMinutes);
                }
            }

            // 출차기록이 없으면 23:59 분 출차로 기록
            if (dic.Value.Count % 2 != 0)
            {
                outTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59");

                TimeSpan dateDiff2 = outTime - inTime;
                totalMinute += Convert.ToInt32(dateDiff2.TotalMinutes);
            }

            double parkingPrice = 0;

            if (totalMinute <= fees[0])
            {
                parkingPrice = fees[1];
            }
            else
            {
                parkingPrice = fees[1] + Math.Ceiling((totalMinute - fees[0]) / fees[2]) * fees[3];
            }

            answerList.Add(Convert.ToInt32(parkingPrice));

            totalMinute = 0;
        }

        var answer = answerList.ToArray();

        return answer;
    }
}
  
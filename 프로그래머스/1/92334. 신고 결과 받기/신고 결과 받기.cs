using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
             var tReport = report.Distinct().
                Select(s => s.Split(' ')).
                GroupBy(g => g[1]).
                Where(w => w.Count() >= k).
                SelectMany(sm => sm.Select(s => s[0])).
                ToList();

            return id_list.ToDictionary(x => x, x => tReport.Count(c => x == c)).Values.ToArray();
    }
}

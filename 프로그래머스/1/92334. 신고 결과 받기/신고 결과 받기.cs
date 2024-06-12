using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        if( k > id_list.Length)
            return new int[id_list.Length];
        Dictionary<string, int> result = new Dictionary<string, int>();
        ReportData[] rData = new ReportData[id_list.Length];
        
        for(int i = 0; i < id_list.Length; i++){
            result.Add(id_list[i], 0);
            rData[i] = new ReportData{name = id_list[i], ReportPeople = new HashSet<string>()};
        }
        foreach(string ids in report){
            string[] id = ids.Split(' ');
            rData.First(x => x.name == id[1]). ReportPeople.Add(id[0]);
        }
        for(int i = 0; i < id_list.Length; i++){
            if(rData[i].ReportCount < k)
                continue;
            foreach(var id in rData[i].ReportPeople)
                result[id]++;
        }
        return result.Select(x => x.Value).ToArray();
    }
}
public class ReportData{
    public string name {get; set;}
    public int ReportCount {get {return ReportPeople.Count;}}
    public HashSet<string> ReportPeople {get; set;}
}

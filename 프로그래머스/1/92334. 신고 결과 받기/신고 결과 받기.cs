using System;
using System.Collections;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] id_list, string[] report, int k) 
    {
        int[] answer = new int[id_list.Length];

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < report.Length; i++)
        {
            string[] str = report[i].Split(' ');

            string give = str[0];
            string take = str[1];

            if (!dic.ContainsKey(take))
            {
                List<string> list = new List<string>();
                list.Add(give);
                dic.Add(take, list);
                continue;
            }

            if (!dic[take].Contains(give))
            {
                dic[take].Add(give);
            }
        }

        for (int i = 0; i < id_list.Length; i++)
        {
            foreach (KeyValuePair<string, List<string>> item in dic)
            {
                if (item.Value.Contains(id_list[i]))
                {
                    if (item.Value.Count >= k)
                    {
                        answer[i] = ++answer[i];
                    }
                }                
            }
        }

        return answer;
    }
}
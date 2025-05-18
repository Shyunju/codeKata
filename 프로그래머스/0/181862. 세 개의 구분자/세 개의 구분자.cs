using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string myStr) {
        string[] arr1 = myStr.Split('a');
        var list = new List<string>();
        foreach(string i in arr1)
        {
            string[] arr2 = i.Split('b');
            for(int j = 0; j< arr2.Length; j++)
            {
                if(arr2[j].Length == 0)
                    continue;
                list.Add(arr2[j]);
            }
        }
        var answer = new List<string>();
        foreach(string i in list)
        {
            string[] arr3 = i.Split('c');
            for(int j = 0; j < arr3.Length; j++)
            {
                if(arr3[j].Length == 0)
                    continue;
                answer.Add(arr3[j]);
            }
        }
        string[] empty = {"EMPTY"};
        if(answer.Count == 0)
            return empty;
        return answer.ToArray();
        
    }
}
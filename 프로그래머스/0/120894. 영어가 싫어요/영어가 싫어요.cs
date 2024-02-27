using System;
using System.Collections.Generic;
public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        List<string> num = new List<string>();
        string number = "";
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
        };
        
        char[] chars = numbers.ToCharArray();
        for(int i = 0 ; i <chars.Length; i++)
        {
            number += chars[i].ToString();
            if(dict.ContainsKey(number))
            {
                num.Add(dict[number].ToString());
                number = "";
            }
        }
        string str = string.Join("", num);
        return answer = long.Parse(str);
    }
}
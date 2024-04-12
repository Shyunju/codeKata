using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        List<int> nums = new List<int>();
        List<string> cal = new List<string>();
        string new_string = my_string.Replace(" ", string.Empty);
        int num = 0;
        foreach(var i in new_string)
        {
            int n = 0;
            bool isInt = int.TryParse(i.ToString(), out n);
            if(isInt)
            {
                num *= 10;
                num += n;
            }else{
                nums.Add(num);
                num = 0;
                cal.Add(i.ToString());
            }
        }
        nums.Add(num);
        answer = nums[0];
        for(int i = 0; i< cal.Count; i++)
        {
            if(cal[i] == "+")
                answer += nums[i+1];
            else
                answer -= nums[i+1];
        }
        return answer;
    }
}
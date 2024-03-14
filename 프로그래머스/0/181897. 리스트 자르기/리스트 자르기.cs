using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        List<int> answer = new List<int>();
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];
        
        switch(n)
        {
            case 1:
                answer = num_list.Take(b+1).ToList();
                break;
            case 2:
                answer = num_list.Skip(a).ToList();
                break;
            case 3:
                answer = num_list.Skip(a).Take(b-a+1).ToList();
                break;
            case 4:
                for(int i = a; i <= b; i += c)
                {
                    answer.Add(num_list[i]);
                }
                break;
        }
        return answer.ToArray();
    }
}
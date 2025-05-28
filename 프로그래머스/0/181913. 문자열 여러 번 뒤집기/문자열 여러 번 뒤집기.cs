using System;
using System.Linq;
public class Solution {
    public string solution(string my_string, int[,] queries) {
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            string temp = my_string.Substring(0,queries[i,0]);
            string rev = my_string.Substring(queries[i,0], queries[i,1] - queries[i,0] + 1);
            temp += new String(rev.Reverse().ToArray());
            temp += my_string.Substring(queries[i,1] + 1);
            my_string = temp;
        }
        return my_string;
    }
}
using System;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        HashSet<string> log = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());
        for(int i =0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            string action = input[1];
            if(action == "enter")
                log.Add(name);
            else
                log.Remove(name);
        }
        List<string> now = new List<string>(log);
        now.Sort();
        now.Reverse();
        StringBuilder sb = new StringBuilder();
        foreach(string i in now)
        {
            sb.AppendLine(i);
        }
        Console.Write(sb.ToString());
    }
}
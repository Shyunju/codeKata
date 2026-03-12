using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        List<int> num = new List<int>();
        int n = int.Parse(Console.ReadLine());
        string[] sl = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0; i < n; i++)
        {
            num.Add(int.Parse(sl[i]));
        }
        num.Sort();
        
        
        int m = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < m; i++)
        {
            sb.Append(p.Upper(int.Parse(input[i]), num)- p.Lower(int.Parse(input[i]), num) + " ");
        }
        Console.WriteLine(sb.ToString());
    }
    public int Lower(int target, List<int> num)
    {
        int st = 0;
        int en = num.Count();
        
        while(st < en)
        {
            int mid = (en + st)/2;
            if(num[mid] >= target)
                en = mid;
            else
                st = mid+1;
        }
        return st;
    }
    public int Upper(int target, List<int> num)
    {
        int st = 0;
        int en = num.Count();
        
        while(st < en)
        {
            int mid = (en + st)/2;
            if(num[mid] > target)
                en = mid;
            else
                st = mid + 1;
        }
        return st;
    }
}
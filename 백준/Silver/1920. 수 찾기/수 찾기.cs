using System;
using System.Text;
public class Program
{
    
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        string[] sl = Console.ReadLine().Split();
        for(int i = 0; i < n; i++)
        {
            num[i] = int.Parse(sl[i]);
        }
        Array.Sort(num);
        int m = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        StringBuilder sb = new StringBuilder(); // 출력을 모으기 위한 도구

        for(int i = 0; i < m; i++)
        {
            sb.AppendLine(p.solve(int.Parse(input[i]), num).ToString());
        }

        Console.Write(sb.ToString());
    }
    public int solve(int cur, int[] num)
    {
        int st = 0;
        int en = num.Length-1;
        while(en >= st)
        {
            int mid =(en + st) / 2;
            if(num[mid] == cur)    return 1;
            if(num[mid] < cur)
            {
                st = mid + 1;
            }
            else if(num[mid] > cur)
            {
                en = mid -1;
            }
        }
        return 0;
    }
}
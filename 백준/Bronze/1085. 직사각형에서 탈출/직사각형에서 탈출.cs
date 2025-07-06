 using System;

public class Program
{
    static void Main(string[] args)
    {
        string s= Console.ReadLine();
        string[] sl = s.Split();
        int x = int.Parse(sl[0]);
        int y = int.Parse(sl[1]);
        int w = int.Parse(sl[2]);
        int h = int.Parse(sl[3]);
        
        int r = w - x;
        int t = h - y;
        
        int[] result = {x, y, r, t};
        Console.WriteLine(result.Min());
    }
}
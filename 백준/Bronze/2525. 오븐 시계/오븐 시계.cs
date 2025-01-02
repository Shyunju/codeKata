using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        int time = int.Parse(Console.ReadLine());
        
        string[] sl = s.Split(" ");
        int h = int.Parse(sl[0]);
        int m = int.Parse(sl[1]);
        
        int th = time / 60;
        int tm = time % 60;
        m += tm;
        h += th;
        if(m >= 60){
            h++;
            m -= 60;           
        }
        if(h >= 24)
            h -= 24;
        Console.WriteLine(h + " " + m);
    }
}
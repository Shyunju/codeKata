 using System;

internal class Program
{
    static void Main(string[] args){
        string[] sl = Console.ReadLine().Split();
        int a = int.Parse(sl[0]);
        int b = int.Parse(sl[1]);
        int v = int.Parse(sl[2]);
        int n = 0;
        
        int days = 0;
        days = (v-a) / (a-b) - 1;
        n = days * (a-b);
        while(true){
            days++;
            n += a;
            if( n >= v)
                break;
            n -= b;
        }
        Console.Write(days);
    }
}
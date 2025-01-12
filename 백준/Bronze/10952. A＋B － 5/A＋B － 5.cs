using System;

internal class Program
{
    static void Main(string[] args){
        int n = 1;
        while(n > 0){
            string s = Console.ReadLine();
            string[] sl =s.Split(" ");
            n = int.Parse(sl[0]) + int.Parse(sl[1]);
            if(n >0)
                Console.WriteLine(n);
        }
    }
}
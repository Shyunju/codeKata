using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args){
        Console.ReadLine();
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        int[] num = new int[sl.Length];
        
        for(int i = 0; i < sl.Length; i++){
            num[i] = int.Parse(sl[i]);
        }
        
        Console.WriteLine(num.Min() + " " + num.Max());
    }
}
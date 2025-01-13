using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string[] sl = s.Split();
        int[] num = Array.ConvertAll(sl, s => int.Parse(s));
        
        int find = int.Parse(Console.ReadLine());
        var answer = num.Where(w => w == find);
        Console.WriteLine(answer.Count());
    }
}
using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        
        Console.Write(s[n-1]);
    }
}
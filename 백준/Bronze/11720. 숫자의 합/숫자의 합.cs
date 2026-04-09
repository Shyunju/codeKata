using System;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int answer = 0;
        foreach(char c in s){
             answer += int.Parse(c.ToString());
        }
        Console.Write(answer);
    }
}
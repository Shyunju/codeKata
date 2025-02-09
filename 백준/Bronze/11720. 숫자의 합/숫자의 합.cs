using System;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int answer = 0;
        for(int i = 0; i < n; i++){
             answer += int.Parse(s[i].ToString());
        }
        Console.WriteLine(answer);
    }
}
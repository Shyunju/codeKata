using System;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int answer = 0;
        
        for(int i = 1; i <= n; i++){
            answer += i;
        }
        Console.WriteLine(answer);
    }
}
using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args){
        var answer = new HashSet<int>();
        
        for(int i = 0; i < 10; i++){
            int n = int.Parse(Console.ReadLine());
            answer.Add(n % 42);
        }
        Console.Write(answer.Count());
    }
}
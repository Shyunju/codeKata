using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        
        double answer = 0;
        for(int i = 0; i < sl.Length; i++){
            answer += Double.Parse(sl[i]);
        }
        Console.WriteLine(answer);
    }
}
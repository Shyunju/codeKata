using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args){
        Console.ReadLine();
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        
        double[] score = new double[sl.Length];
        for(int i = 0;i < sl.Length; i++){
            score[i] = Double.Parse(sl[i]);
        }
        
        double max = score.Max();
        for(int i = 0; i < score.Length; i++){
            score[i] = score[i]/max*100;
        }
        Console.Write(score.Average());
    }
}
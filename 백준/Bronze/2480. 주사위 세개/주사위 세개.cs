using System;
using System.Linq;
internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split();
        int[] dice = new int[sl.Length];
        for(int i = 0; i < sl.Length; i++){
            dice[i] = int.Parse(sl[i]);
        }
        int answer = 0;
        if(dice[0] == dice[1] && dice[1] == dice[2])
            answer = 10000 + dice[0] * 1000;
        else if(dice[0] == dice[1] || dice[0] == dice[2])
            answer = 1000 + dice[0] * 100;
        else if(dice[1] == dice[2])
            answer = 1000 + dice[1] * 100;
        else
            answer = dice.Max() * 100;
                                                      
        Console.WriteLine(answer);                             
    }
              
}
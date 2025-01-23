using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args){
        List<string> answer = new List<string>();
        int t = int.Parse(Console.ReadLine());
        for(int i = 0; i < t; i++){
            string s = Console.ReadLine();
            if(s == null)
                break;
            string n = s[0].ToString() + s[s.Length-1].ToString();
            answer.Add(n);
        }
        for(int i = 0; i<answer.Count(); i++)
            Console.WriteLine(answer[i]);
    }
}
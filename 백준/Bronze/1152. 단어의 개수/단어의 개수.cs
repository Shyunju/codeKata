using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine().Trim();
        int answer = 0;
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] == ' ')
                answer++;
        }
        if(s.Length == 0)
            Console.Write(0);
        else
            Console.Write(answer+1); 
        
    }
}
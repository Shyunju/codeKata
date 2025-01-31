using System;

internal class Program
{
    static void Main(string[] args){
        int front = 0;
        string s = Console.ReadLine();
        int behind = s.Length-1;
        bool answer = true;
        while(front <= s.Length/2){
            if(s[front] == s[behind]){
                front++;
                behind--;
            }else{
                answer = false;
                break;
            }
        }
        if(answer)
            Console.Write(1);
        else
            Console.Write(0);
    }
}
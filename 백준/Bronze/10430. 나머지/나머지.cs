//첫째 줄에 (A+B)%C, 둘째 줄에 ((A%C) + (B%C))%C, 셋째 줄에 (A×B)%C, 넷째 줄에 ((A%C) × (B%C))%C를 출력한다.

using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        
        int a = int.Parse(sl[0]);
        int b = int.Parse(sl[1]);
        int c = int.Parse(sl[2]);
        
        Console.WriteLine((a+b)%c);
        Console.WriteLine(((a%c) + (b%c)) % c);
        Console.WriteLine((a*b)%c);
        Console.WriteLine(((a%c) * (b%c)) % c);

    }
}
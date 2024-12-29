using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        
        int a = int.Parse(sl[0]);
        int b = int.Parse(sl[1]);
        
        if(a > b)
            Console.WriteLine(">");
        else if(a < b)
            Console.WriteLine("<");
        else
            Console.WriteLine("==");
    }
}
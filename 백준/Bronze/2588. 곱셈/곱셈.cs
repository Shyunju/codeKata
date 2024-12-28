using System;

internal class Program
{
    static void Main(string[] args){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        int c = b;
        
        while(b > 0){
            Console.WriteLine(a*(b % 10));
            b /= 10;
        }
        Console.WriteLine(a*c);
    }
}
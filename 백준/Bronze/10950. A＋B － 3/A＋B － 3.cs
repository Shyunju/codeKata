using System;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < n; i++){
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");
            int a = int.Parse(sl[0]);
            int b = int.Parse(sl[1]);
            
            Console.WriteLine(a + b);
        }
    }
}
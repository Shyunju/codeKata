using System;

internal class Program
{
    static void Main(string[] args){
        int max = 0;
        int y = 0;
        int x = 0;
        int n = 0;
        
        for(int i = 1; i <= 9; i++){
            string[] s = Console.ReadLine().Split(" ");
            for(int j = 0; j < 9; j++){
                n = int.Parse(s[j]);
                if(n >= max){
                    max = n;
                    y = i;
                    x = j+1;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(y + " " + x);
    }
}
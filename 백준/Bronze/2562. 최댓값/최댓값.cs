using System;

internal class Program
{
    static void Main(string[] args){
        int max = 0;
        int idx = 0;
        for(int i = 1; i <= 9; i++){
            int n = int.Parse(Console.ReadLine());
            if(n > max){
                max = n;
                idx = i;
            }
        }
        Console.WriteLine(max + "\n" + idx);
    }
}
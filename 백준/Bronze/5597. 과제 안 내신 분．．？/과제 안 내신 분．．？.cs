using System;

internal class Program
{
    static void Main(string[] args){
        bool[] check = new bool[31];
        
        for(int i = 0; i < 28; i++){
            int idx = int.Parse(Console.ReadLine());
            check[idx] = true;
        }
        for(int i = 1; i < 31; i++){
            if(!check[i])
                Console.WriteLine(i);
        }
    }
}
using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        int n = int.Parse(sl[0]);
        int m = int.Parse(sl[1]);
        
        int[] basket = new int[n];
        
        for(int i = 0; i < m; i++){
            s = Console.ReadLine();
            string[] order = s.Split(" ");
            int start = int.Parse(order[0]);
            int end = int.Parse(order[1]);
            int num = int.Parse(order[2]);
            for(int j = start; j <= end; j++){
                basket[j-1] = num;
            }
        }
        for(int i = 0; i < n; i++){
            Console.Write(basket[i] + " ");
        }
    }
}
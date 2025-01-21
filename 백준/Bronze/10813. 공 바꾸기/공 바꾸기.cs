using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        string[] sl = s.Split(" ");
        int n = int.Parse(sl[0]);
        int m = int.Parse(sl[1]);
        
        int[] basket = new int[n+1];
        for(int i = 0; i < n+1; i++)
            basket[i] = i;
        
        int temp = 0;
        int a = 0;
        int b = 0;
        for(int i = 0; i < m; i++){
            s = Console.ReadLine();
            string[] order = s.Split(" ");
            a = int.Parse(order[0]);
            b = int.Parse(order[1]);
            
            temp = basket[a];
            basket[a] = basket[b];
            basket[b] = temp;            
        }
        
        for(int i = 1; i < n+1; i++)
            Console.Write(basket[i] + " ");
        
    }
}
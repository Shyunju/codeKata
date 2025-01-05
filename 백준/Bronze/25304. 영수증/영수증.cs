using System;

internal class Program
{
    static void Main(string[] args){
        double total = Double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        double sum = 0;
        for(int i = 0; i <n; i++){
            string s = Console.ReadLine();
            string[] sl = s.Split(" ");
            
            double price = Double.Parse(sl[0]);
            double cnt = Double.Parse(sl[1]);
            
            sum += price * cnt;
        }
        if(sum == total)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
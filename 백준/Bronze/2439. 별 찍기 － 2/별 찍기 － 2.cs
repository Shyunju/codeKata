using System;
using System.Text;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new();
        
        int a = 0;
        for(int i = 1; i <= n; i++){
            a = n - i;
            sb.Append(' ', a);
            sb.Append('*', i);
            sb.AppendLine();
        }
        Console.Write(sb.ToString());
    }
}
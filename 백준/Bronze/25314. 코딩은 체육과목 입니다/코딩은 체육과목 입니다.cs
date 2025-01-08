using System;
using System.Text;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        
        StringBuilder sb = new StringBuilder();
        int limit = n / 4;
        for(int i = 0; i < limit; i++){
            sb.Append("long ");
        }
        Console.WriteLine(sb.ToString() + "int");
    }
}
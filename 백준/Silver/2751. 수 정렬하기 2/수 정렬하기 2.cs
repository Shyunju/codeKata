using System;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for(int i = 0; i < n; i++){
            int m = int.Parse(Console.ReadLine());
            num[i] = m;
        }
        Array.Sort(num);
        StringBuilder sb = new StringBuilder(string.Join("\n", num));
        Console.WriteLine(sb);
    }
}
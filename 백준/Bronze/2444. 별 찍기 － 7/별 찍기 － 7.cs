using System;

class Program
{
    static void Main() {
        int n=int.Parse(Console.ReadLine());
        for(int i=1;i<=n;i++){
            for(int j=0;j<n-i;j++) Console.Write(" ");
            for(int j=0;j<(i-1)*2+1;j++) Console.Write("*");
            Console.WriteLine();
        }
        for(int i=n-1;i>=1;i--){
            for(int j=0;j<n-i;j++) Console.Write(" ");
            for(int j=0;j<(i-1)*2+1;j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}
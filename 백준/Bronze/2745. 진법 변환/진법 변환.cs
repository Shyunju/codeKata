using System;

internal class Program
{
    static void Main(string[] args){
        string[] token = Console.ReadLine().Split();
        string n = token[0];
        int b = int.Parse(token[1]);
        double answer = 0;
        
        for(int i = n.Length-1; i >= 0; i--){
            int digit = 0;
            if(char.IsDigit(n[i]))
                digit = int.Parse(n[i].ToString());
            else
                digit = (int)n[i] - 55;
            
            answer +=  Math.Pow(b, n.Length-1-i) * digit;
        }
        Console.Write(answer);
    }
}
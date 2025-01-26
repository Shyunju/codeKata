using System;

internal class Program
{
    static void Main(string[] args){
        while(true){
            string s = Console.ReadLine();
            if(s != null)
                Console.WriteLine(s);
            else
                break;
        }
    }
}
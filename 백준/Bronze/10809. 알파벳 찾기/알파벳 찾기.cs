using System;

internal class Program
{
    static void Main(string[] args){
        string s = Console.ReadLine();
        char[] str = s.ToCharArray();
        char c;
        for( int i = 97; i <= 122; i++){
            c = Convert.ToChar(i);
            Console.Write(Array.IndexOf(str, c) + " ");
        }
    }
}
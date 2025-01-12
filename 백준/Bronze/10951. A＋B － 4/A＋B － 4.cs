using System;
internal class Program
{
    static void Main(string[] args){
        int n = 0;
        while(true){
            string s = Console.ReadLine();
            if(s == null)
                break;
            string[] sl = s.Split(" ");
            n = int.Parse(sl[0]) + int.Parse(sl[1]);
            Console.WriteLine(n);
        }
    }
}
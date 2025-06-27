//쿼터(Quarter, $0.25)의 개수, 다임(Dime, $0.10)의 개수, 니켈(Nickel, $0.05)의 개수, 페니(Penny, $0.01)
using System;

public class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        int n = int.Parse(Console.ReadLine());
        int[] result = new int[4];
        
        for(int i = 0; i < n; i++)
        {
            int money = int.Parse(Console.ReadLine());
            result[0] = money / 25;
            money %= 25;
            result[1] = money / 10;
            money %= 10;
            result[2] = money / 5;
            money %= 5;
            result[3] = money / 1;
        
            foreach(int item in result)
            {
                Console.Write($"{item} ");
            }
        }
        
    }
}
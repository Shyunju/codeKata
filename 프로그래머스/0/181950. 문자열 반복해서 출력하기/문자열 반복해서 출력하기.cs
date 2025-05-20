using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);
        
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < a; i++)
        {
            sb.Append(s1);
        }
        string answer = sb.ToString();
        Console.WriteLine(answer);

    }
}
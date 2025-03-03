using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        string answer = a % 2 == 0 ? a + " is even" : a + " is odd";
        Console.Write(answer);
    }
}
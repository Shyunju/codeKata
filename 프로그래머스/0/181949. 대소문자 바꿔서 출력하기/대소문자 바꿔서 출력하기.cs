using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        char[] chArr= s.ToCharArray();
        for(int i = 0; i < chArr.Length; i++)
        {
            if(chArr[i] > 96)
            {
                chArr[i] = char.ToUpper(chArr[i]);
            }else{
                chArr[i] = char.ToLower(chArr[i]);
            }
        }
        s = new String(chArr);
        Console.WriteLine(s);

    }
}
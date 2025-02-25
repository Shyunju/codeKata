using System;
using System.Collections;
class son
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int n=int.Parse(input[0]);
		int b=int.Parse(input[1]);
		ArrayList arr = new ArrayList();
		while(n>0)
		{
			
			int temp=n%b;
			n=n/b;
			if(temp>=10)
			{
				temp+=55;
				arr.Add((char)temp);
			}
			else
			{
				arr.Add(temp);	
			}			
		}
		arr.Reverse();
		foreach(var a in arr)
		{Console.Write(a);}
		
	}
}
using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine("Enter Any Number");
		string num;
		num = Console.ReadLine();
		int n = Convert.ToInt32(num);

		if ((n/2)*2 == n) {
			 Console.Write("The Given Number is Even");
             Console.ReadLine();
		} else {
			 Console.Write("The Given Number is Odd");
             Console.ReadLine();
		}
	}
}